import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { QuestionGrid } from './QuestionGrid';

export default function pageInit() {
    initFullHeightGridPage(new QuestionGrid($('#GridDiv')).element);
}