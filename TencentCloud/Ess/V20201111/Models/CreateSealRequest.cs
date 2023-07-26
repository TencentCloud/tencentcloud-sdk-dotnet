/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 电子印章名字
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 应用相关信息
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 本接口支持上传图片印章及系统直接生成印章；如果要使用系统生成印章，此值传：SealGenerateSourceSystem；如果要使用图片上传请传字段 Image
        /// </summary>
        [JsonProperty("GenerateSource")]
        public string GenerateSource{ get; set; }

        /// <summary>
        /// 电子印章类型，OFFICIAL-公章,CONTRACT-合同专用章
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 电子印章图片文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 电子印章图片base64编码
        /// 参数Image,FileToken或GenerateSource=SealGenerateSourceSystem三选一。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 电子印章宽度,单位px
        /// 参数不再启用，系统会设置印章大小为标准尺寸。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 电子印章高度,单位px
        /// 参数不再启用，系统会设置印章大小为标准尺寸。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 电子印章印章颜色(默认红色RED),RED-红色
        /// 
        /// 系统目前只支持红色印章创建。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 暂时不支持横向文字设置
        /// </summary>
        [JsonProperty("SealHorizontalText")]
        public string SealHorizontalText{ get; set; }

        /// <summary>
        /// 暂时不支持下弦文字设置
        /// </summary>
        [JsonProperty("SealChordText")]
        public string SealChordText{ get; set; }

        /// <summary>
        /// 系统生成的印章只支持STAR
        /// </summary>
        [JsonProperty("SealCentralType")]
        public string SealCentralType{ get; set; }

        /// <summary>
        /// 通过文件上传时，服务端生成的电子印章上传图片的token
        /// </summary>
        [JsonProperty("FileToken")]
        public string FileToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "GenerateSource", this.GenerateSource);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "SealHorizontalText", this.SealHorizontalText);
            this.SetParamSimple(map, prefix + "SealChordText", this.SealChordText);
            this.SetParamSimple(map, prefix + "SealCentralType", this.SealCentralType);
            this.SetParamSimple(map, prefix + "FileToken", this.FileToken);
        }
    }
}

