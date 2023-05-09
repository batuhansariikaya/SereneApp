import { fieldsProxy } from "@serenity-is/corelib/q";

export interface GradeRow {
    GradeId?: number;
    Code?: string;
    Name?: string;
    Capacity?: number;
    Status?: boolean;
}

export abstract class GradeRow {
    static readonly idProperty = 'GradeId';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'School.Grade';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<GradeRow>();
}