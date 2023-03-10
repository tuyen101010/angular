import { IThemeAssetContributor } from '../ThemeAssetContributor';

export class Theme11ThemeAssetContributor implements IThemeAssetContributor {
    public getAssetUrls(): string[] {
        return [''];
    }

    public getAdditionalBodyStyle(): string {
        return '';
    }

    public getMenuWrapperStyle(): string {
        return '';
    }

    public getSubheaderStyle(): string {
        return 'text-dark fw-bold my-1 me-5 ms-5';
    }

    public getFooterStyle(): string {
        return 'footer py-4 d-flex flex-lg-column ';
    }
}
