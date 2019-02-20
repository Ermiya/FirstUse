import { FirstUseTemplatePage } from './app.po';

describe('FirstUse App', function() {
  let page: FirstUseTemplatePage;

  beforeEach(() => {
    page = new FirstUseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
