using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NITGEN.SDK.NBioBSP;
using TccBiblioteca;

namespace ModuloBiometria
{
    public class Biometria
    {
        private NBioAPI api;

        public Biometria()
        {
           api = new NBioAPI();
           api.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
        }

        public String CapturarDigitaisParaInscricao()
        {
            try
            {
                NBioAPI.Type.HFIR template = new NBioAPI.Type.HFIR();

                uint retorno = api.Enroll(out template, null);

                if (retorno == NBioAPI.Error.NONE)
                {
                    NBioAPI.Type.FIR_TEXTENCODE binario = new NBioAPI.Type.FIR_TEXTENCODE();
                    api.GetTextFIRFromHandle(template, out binario, false);
                    return binario.TextFIR;
                }
                else {
                    Console.WriteLine(retorno);
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao capturar as digitais.", ex);
            }
        }

        public string CapturarDigitalParaVerificacao()
        {
            NBioAPI.Type.HFIR template = new NBioAPI.Type.HFIR();
            
            uint retorno = api.Capture(out template);

            if (retorno == NBioAPI.Error.NONE)
            {
                NBioAPI.Type.FIR_TEXTENCODE binario = new NBioAPI.Type.FIR_TEXTENCODE();
                api.GetTextFIRFromHandle(template, out binario, false);
                return binario.TextFIR;
            }

            throw new Exception("Erro ao capturar a digital.");
        }

        public bool VerificarDigitais(String digitalCapturada, String digitaisSalvas)
        {
            bool resultado = false;

            NBioAPI.Type.FIR_TEXTENCODE salvas = ToFIR_TextEncode(digitaisSalvas);
            NBioAPI.Type.FIR_TEXTENCODE capturada = ToFIR_TextEncode(digitalCapturada);

            var payload = new NBioAPI.Type.FIR_PAYLOAD();
            uint retorno = api.VerifyMatch(capturada, salvas, out resultado, payload );

            if (retorno == NBioAPI.Error.NONE)
                return resultado;

            throw new Exception("Erro ao verificar digital: " + retorno);
        }

        private NBioAPI.Type.FIR_TEXTENCODE ToFIR_TextEncode(String templateString)
        {
            NBioAPI.Type.FIR_TEXTENCODE fir = new NBioAPI.Type.FIR_TEXTENCODE();
            fir.TextFIR = templateString;
            return fir;
        }
    }
}
