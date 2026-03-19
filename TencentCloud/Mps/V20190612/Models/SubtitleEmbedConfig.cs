/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleEmbedConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>字体类型，支持：</p><li>hei.ttf：黑体</li><li>song.ttf：宋体</li><li>kai.ttf（推荐）或 simkai.ttf：楷体</li><li>msyh.ttf：微软雅黑</li><li>msyhbd.ttf：微软雅黑加粗</li><li>hkjgt.ttf：华康金刚体</li><li>dhttx.ttf：典黑体特细</li><li>xqgdzt.ttf：喜鹊古字典体</li><li>qpcyt.ttf：巧拼超圆体</li><li>arial.ttf：仅支持英文</li><li>dinalternate.ttf：DIN Alternate Bold</li><li>helveticalt.ttf：Helvetica</li><li>helveticains.ttf：Helvetica Inserat</li><li>trajanpro.ttf：TrajanPro-Bold</li><li>korean.ttf：韩语</li><li>japanese.ttf：日语</li><li>thai.ttf：泰语</li><li>roboto.ttf：Roboto</li><li>notosans.ttf：NotoSans</li><li>notosansthai.ttf：泰语NotoSansThai</li><li>sarabun.ttf：泰语Sarabun</li><li>kanit.ttf：泰语Kanit</li><li>charmonman.ttf：泰语Charmonman</li><li>notonaskharabic.ttf：阿拉伯语NotoNaskhArabic</li><li>notosansdevanagari.ttf：印度语NotoSansDevanagari</li><li>notosanstc.ttf：粤语思源黑体NotoSansTC</li><li>notosanskr.ttf：韩语NotoSansKR</li><li>gothica1.ttf：韩语GothicA1</li><li>nanummyeongjo.ttf：韩语NanumMyeongjo</li><li>notosansjp.ttf：日语NotoSansJP</li><li>notoserifjp.ttf：日语NotoSerifJP</li><li>shipporimincho.ttf：日语ShipporiMincho</li>默认：hei.ttf 黑体。<br>注意：<li>楷体推荐使用kai.ttf</li><li>填了FontPath时FontPath优先</li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// <p>自定义字体文件url地址，和CosInputInfo二选一</p>
        /// </summary>
        [JsonProperty("FontPath")]
        public string FontPath{ get; set; }

        /// <summary>
        /// <p>自定义字体文件cos地址</p>
        /// </summary>
        [JsonProperty("CosInputInfo")]
        public CosInputInfo CosInputInfo{ get; set; }

        /// <summary>
        /// <p>字体大小，不指定则以字幕文件中为准。支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：(0,4096]。</li><li>百分百：N%，N范围：(0,100]；例如10%表示字幕字体大小=10%*源视频高度。</li></ul><p>不填且字幕文件无设置时，默认源视频高度的5%。</p>
        /// </summary>
        [JsonProperty("FontSize")]
        public long? FontSize{ get; set; }

        /// <summary>
        /// <p>FontSize单位, 0 像素，1百分比，默认为0，像素</p>
        /// </summary>
        [JsonProperty("FontSizeUnit")]
        public long? FontSizeUnit{ get; set; }

        /// <summary>
        /// <p>字体颜色，格式：0xRRGGBB，默认值：0xFFFFFF（白色）。</p>
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// <p>文字透明度，取值范围：(0, 1]</p><li>0：完全透明</li><li>1：完全不透明</li>默认值：1。
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// <p>字幕x轴坐标位置，指定此参数会忽略字幕文件自带坐标；支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：[-4096,4096]。</li><li>百分百：N%，N范围：[-100,100]；例如10%表示字幕x坐标=10%*源视频宽度。</li></ul><p>默认值：0px。<br>注意：坐标轴原点在源视频中轴线底部，字幕基准点在字幕中轴线底部，参考下图：<br><img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("PosX")]
        public long? PosX{ get; set; }

        /// <summary>
        /// <p>PosX单位, 0 像素，1百分比，默认为0，像素</p>
        /// </summary>
        [JsonProperty("PosXUnit")]
        public long? PosXUnit{ get; set; }

        /// <summary>
        /// <p>字幕y轴坐标位置，指定此参数会忽略字幕文件自带坐标；支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：[0,4096]。</li><li>百分百：N%，N范围：[0,100]；例如10%表示字幕y坐标=10%*源视频高度。</li></ul><p>默认值：源视频高度*4%。<br>注意：坐标轴原点在源视频中轴线底部，字幕基准点在字幕中轴线底部，参考下图：<br><img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("PosY")]
        public long? PosY{ get; set; }

        /// <summary>
        /// <p>PosY单位, 0 像素，1百分比，默认为0，像素</p>
        /// </summary>
        [JsonProperty("PosYUnit")]
        public long? PosYUnit{ get; set; }

        /// <summary>
        /// <p>背景配置</p>
        /// </summary>
        [JsonProperty("SubtitleBoardConfig")]
        public SubtitleBoardConfig SubtitleBoardConfig{ get; set; }

        /// <summary>
        /// <p>排列配置</p>
        /// </summary>
        [JsonProperty("SubtitleLayoutConfig")]
        public SubtitleLayoutConfig SubtitleLayoutConfig{ get; set; }

        /// <summary>
        /// <p>文字描边配置</p>
        /// </summary>
        [JsonProperty("SubtitleOutlineConfig")]
        public SubtitleOutlineConfig SubtitleOutlineConfig{ get; set; }

        /// <summary>
        /// <p>文字阴影配置</p>
        /// </summary>
        [JsonProperty("SubtitleShadowConfig")]
        public SubtitleShadowConfig SubtitleShadowConfig{ get; set; }

        /// <summary>
        /// <p>源视频尺寸的宽，单位像素值</p>
        /// </summary>
        [JsonProperty("SampleWidth")]
        public long? SampleWidth{ get; set; }

        /// <summary>
        /// <p>源视频尺寸的高，单位像素值</p>
        /// </summary>
        [JsonProperty("SampleHeight")]
        public long? SampleHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontPath", this.FontPath);
            this.SetParamObj(map, prefix + "CosInputInfo.", this.CosInputInfo);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontSizeUnit", this.FontSizeUnit);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosXUnit", this.PosXUnit);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "PosYUnit", this.PosYUnit);
            this.SetParamObj(map, prefix + "SubtitleBoardConfig.", this.SubtitleBoardConfig);
            this.SetParamObj(map, prefix + "SubtitleLayoutConfig.", this.SubtitleLayoutConfig);
            this.SetParamObj(map, prefix + "SubtitleOutlineConfig.", this.SubtitleOutlineConfig);
            this.SetParamObj(map, prefix + "SubtitleShadowConfig.", this.SubtitleShadowConfig);
            this.SetParamSimple(map, prefix + "SampleWidth", this.SampleWidth);
            this.SetParamSimple(map, prefix + "SampleHeight", this.SampleHeight);
        }
    }
}

