import { ProlixTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: ProlixTemplatePage;

  beforeEach(() => {
    page = new ProlixTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
