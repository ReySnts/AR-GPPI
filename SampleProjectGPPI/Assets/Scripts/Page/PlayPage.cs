public class PlayPage : Page
{
    protected override void Awake() => buttonListener.AddAll();

    protected override void OnDestroy() => buttonListener.RemoveAll();
}