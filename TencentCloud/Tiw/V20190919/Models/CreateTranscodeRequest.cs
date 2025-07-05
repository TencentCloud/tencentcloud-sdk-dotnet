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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTranscodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 经过URL编码后的转码文件地址。URL 编码会将字符转换为可通过因特网传输的格式，比如文档地址为http://example.com/测试.pdf，经过URL编码之后为http://example.com/%E6%B5%8B%E8%AF%95.pdf。为了提高URL解析的成功率，请对URL进行编码。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 是否为静态PPT，默认为False；
        /// 如果IsStaticPPT为False，后缀名为.ppt或.pptx的文档会动态转码成HTML5页面，其他格式的文档会静态转码成图片；如果IsStaticPPT为True，所有格式的文档会静态转码成图片；
        /// </summary>
        [JsonProperty("IsStaticPPT")]
        public bool? IsStaticPPT{ get; set; }

        /// <summary>
        /// 注意: 该参数已废弃, 请使用最新的 [云API SDK](https://cloud.tencent.com/document/api/1137/40060#SDK) ，使用 MinScaleResolution字段传递分辨率
        /// 
        /// 转码后文档的最小分辨率，不传、传空字符串或分辨率格式错误则使用文档原分辨率
        /// 
        /// 示例：1280x720，注意分辨率宽高中间为英文字母"xyz"的"x"
        /// </summary>
        [JsonProperty("MinResolution")]
        public string MinResolution{ get; set; }

        /// <summary>
        /// 动态PPT转码可以为文件生成该分辨率的缩略图，不传、传空字符串或分辨率格式错误则不生成缩略图，分辨率格式同MinResolution
        /// </summary>
        [JsonProperty("ThumbnailResolution")]
        public string ThumbnailResolution{ get; set; }

        /// <summary>
        /// 转码文件压缩格式，不传、传空字符串或不是指定的格式则不生成压缩文件，目前支持如下压缩格式：
        /// 
        /// zip： 生成`.zip`压缩包
        /// tar.gz： 生成`.tar.gz`压缩包
        /// </summary>
        [JsonProperty("CompressFileType")]
        public string CompressFileType{ get; set; }

        /// <summary>
        /// 内部参数
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// 文档转码优先级， 只有对于PPT动态转码生效，支持填入以下值：<br/>
        /// - low: 低优先级转码，对于动态转码，能支持500MB（下载超时时间10分钟）以及2000页文档，但资源有限可能会有比较长时间的排队，请酌情使用该功能。<br/>
        /// - 不填表示正常优先级转码，支持200MB文件（下载超时时间2分钟），500页以内的文档进行转码
        /// <br/>
        /// 注意：对于PDF等静态文件转码，无论是正常优先级或者低优先级，最大只能支持200MB
        /// </summary>
        [JsonProperty("Priority")]
        public string Priority{ get; set; }

        /// <summary>
        /// 转码后文档的最小分辨率，不传、传空字符串或分辨率格式错误则使用文档原分辨率。
        /// 分辨率越高，效果越清晰，转出来的图片资源体积会越大，课件加载耗时会变长，请根据实际使用场景配置此参数。
        /// 
        /// 示例：1280x720，注意分辨率宽高中间为英文字母"xyz"的"x"
        /// </summary>
        [JsonProperty("MinScaleResolution")]
        public string MinScaleResolution{ get; set; }

        /// <summary>
        /// 此参数仅对动态转码生效。
        /// 
        /// 是否对不支持元素开启自动处理的功能，默认不开启。
        /// true -- 开启
        /// false -- 不开启
        /// 
        /// 当设置为`true`时，可配合`AutoHandleUnsupportedElementTypes`参数使用，具体有哪些不兼容元素类型，可参考`AutoHandleUnsupportedElementTypes`参数的说明。
        /// </summary>
        [JsonProperty("AutoHandleUnsupportedElement")]
        public bool? AutoHandleUnsupportedElement{ get; set; }

        /// <summary>
        /// 此参数仅在`AutoHandleUnsupportedElement`参数为`true`的情况下有效。
        /// 
        /// 指定需要自动处理的不兼容元素类型，默认对所有不兼容的元素进行自动处理。
        /// 
        /// 目前支持检测的不兼容元素类型及对应的自动处理方式如下：
        /// 0: 不支持的墨迹类型
        /// -- 自动处理方式：移除墨迹
        /// 
        /// 1: 自动翻页
        /// -- 自动处理方式：移除自动翻页设置，并修改为单击切换
        /// 
        /// 2: 已损坏音视频
        /// -- 自动处理方式：移除对损坏音视频的引用
        /// 
        /// 3: 不可访问资源
        /// -- 自动处理方式：移除对不可访问的资源的引用
        /// 
        /// 4: 只读文件
        /// -- 自动处理方式：移除只读设置
        /// 
        /// 5: 不支持的元素编辑锁定状态
        /// -- 自动处理方式：移除锁定状态
        /// 
        /// 6: 可能有兼容问题的字体
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 7: 设置了柔化边缘的GIF图片
        /// -- 自动处理方式：移除柔化边缘设置
        /// 
        /// 8: 存在不兼容的空格下划线
        /// -- 自动处理方式：通过调整空格下划线前后文本的字体语言体系，保证空格下划线表现正常
        /// 
        /// 9: 存在设置了分段动画的数学公式和文本混合内容
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 10: 存在设置了分段动画的渐变色文本
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 11: 存在不兼容的分散对齐方式
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 12: 存在不兼容的多倍行距设置
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 13: 存在带有特殊符号内容的datetime类型的a:fld标签元素
        /// -- 自动处理方式： a:fld标签替换为普通文本
        /// </summary>
        [JsonProperty("AutoHandleUnsupportedElementTypes")]
        public long?[] AutoHandleUnsupportedElementTypes{ get; set; }

        /// <summary>
        /// Excel表格转码参数，可设置转码时表格纸张大小及纸张方向等参数（仅对转码文件为Excel表格文件的静态转码任务生效）
        /// </summary>
        [JsonProperty("ExcelParam")]
        public ExcelParam ExcelParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "IsStaticPPT", this.IsStaticPPT);
            this.SetParamSimple(map, prefix + "MinResolution", this.MinResolution);
            this.SetParamSimple(map, prefix + "ThumbnailResolution", this.ThumbnailResolution);
            this.SetParamSimple(map, prefix + "CompressFileType", this.CompressFileType);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "MinScaleResolution", this.MinScaleResolution);
            this.SetParamSimple(map, prefix + "AutoHandleUnsupportedElement", this.AutoHandleUnsupportedElement);
            this.SetParamArraySimple(map, prefix + "AutoHandleUnsupportedElementTypes.", this.AutoHandleUnsupportedElementTypes);
            this.SetParamObj(map, prefix + "ExcelParam.", this.ExcelParam);
        }
    }
}

