import { StringEditor, IntegerEditor, BooleanEditor, DateEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface QuestionForm {
    QuestionTitle: StringEditor;
    OptionA: StringEditor;
    OptionB: StringEditor;
    OptionC: StringEditor;
    OptionD: StringEditor;
    AnswerKey: IntegerEditor;
    Status: BooleanEditor;
    CreatedDate: DateEditor;
    ExamId: LookupEditor;
}

export class QuestionForm extends PrefixedContext {
    static formKey = 'School.Question';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionForm.init)  {
            QuestionForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;
            var w4 = LookupEditor;

            initFormType(QuestionForm, [
                'QuestionTitle', w0,
                'OptionA', w0,
                'OptionB', w0,
                'OptionC', w0,
                'OptionD', w0,
                'AnswerKey', w1,
                'Status', w2,
                'CreatedDate', w3,
                'ExamId', w4
            ]);
        }
    }
}