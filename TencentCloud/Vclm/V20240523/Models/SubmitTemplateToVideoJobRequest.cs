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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTemplateToVideoJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 特效模板名称。请在 [视频特效模板列表](https://cloud.tencent.com/document/product/1616/119194)  中选择想要生成的特效对应的 template 名称。
        /// </summary>
        [JsonProperty("Template")]
        public string Template{ get; set; }

        /// <summary>
        /// 参考图像，不同特效输入图片的数量详见： [视频特效模板-图片要求说明](https://cloud.tencent.com/document/product/1616/119194)
        /// - 支持传入图片Base64编码或图片URL（确保可访问）
        /// - 图片格式：支持png、jpg、jpeg、webp、bmp、tiff
        /// - 图片文件：大小不能超过10MB（base64后），图片分辨率不小于300*300px，不大于4096*4096，图片宽高比应在1:4 ~ 4:1之间
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// 为生成视频添加标识的开关，默认为1。传0 需前往  [控制台](https://console.cloud.tencent.com/vtc/setting) 申请开启显式标识自主完成后方可生效。
        /// 1：添加标识；
        /// 0：不添加标识；
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示，该视频是 AI 生成的视频。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成视频的右下角添加“ AI 生成”或“视频由 AI 生成”字样，如需替换为其他的标识图片，需前往  [控制台](https://console.cloud.tencent.com/vtc/setting) 申请开启显式标识自主完成。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// 视频输出分辨率，默认值：360p 。不同特效支持的清晰度及消耗积分数详见：[视频特效模板-单次调用消耗积分数列](https://cloud.tencent.com/document/product/1616/119194 )
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 是否为生成的视频添加背景音乐。默认：false，  传 true 时系统将从预设 BGM 库中自动挑选合适的音乐并添加；不传或为 false 则不添加 BGM。
        /// </summary>
        [JsonProperty("BGM")]
        public bool? BGM{ get; set; }

        /// <summary>
        /// 扩展字段。
        /// </summary>
        [JsonProperty("ExtraParam")]
        public ExtraParam ExtraParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "BGM", this.BGM);
            this.SetParamObj(map, prefix + "ExtraParam.", this.ExtraParam);
        }
    }
}

