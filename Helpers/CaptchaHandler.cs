using System.Diagnostics;
using nng_one.Logging;
using VkNet.Utils.AntiCaptcha;

namespace nng_one.Helpers;

public class CaptchaHandler : ICaptchaSolver
{
    private readonly InputHandler _input = InputHandler.GetInstance();

    public string Solve(string url)
    {
        Process.Start(new ProcessStartInfo {FileName = url, UseShellExecute = true});
        var captcha = _input.GetStringInput($"Введите каптчу ({url})");
        return captcha;
    }

    public void CaptchaIsFalse()
    {
        Logger.Log("Каптча не пройдена", LogType.Error);
    }
}
