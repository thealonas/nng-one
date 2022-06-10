namespace nng_one.Configs;

public struct Config
{
    public string Token { get; set; }
    public string BanReason { get; set; }
    public string DataUrl { get; set; }
    public bool CaptchaBypass { get; init; }
    public bool SwitchCallback { get; init; }
    public bool Sentry { get; init; }
}
