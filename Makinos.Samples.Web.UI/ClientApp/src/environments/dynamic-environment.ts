declare var window: any;

export class DynamicEnvironment {
  public get apiUrl() {
    return window.config.apiUrl;
  }
}
