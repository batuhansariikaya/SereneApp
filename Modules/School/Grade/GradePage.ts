import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GradeGrid } from './GradeGrid';

export default function pageInit() {
    initFullHeightGridPage(new GradeGrid($('#GridDiv')).element);
}