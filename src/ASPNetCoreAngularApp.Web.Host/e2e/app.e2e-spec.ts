import { ASPNetCoreAngularAppTemplatePage } from './app.po';

describe('ASPNetCoreAngularApp App', function() {
  let page: ASPNetCoreAngularAppTemplatePage;

  beforeEach(() => {
    page = new ASPNetCoreAngularAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
