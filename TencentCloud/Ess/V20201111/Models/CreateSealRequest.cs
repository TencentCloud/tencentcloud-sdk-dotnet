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
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 电子印章名字，1-50个中文字符。
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 本接口支持上传图片印章及系统直接生成印章；
        /// 如果要使用系统生成印章，此值传：SealGenerateSourceSystem；
        /// 如果要使用图片上传请传字段 Image
        /// </summary>
        [JsonProperty("GenerateSource")]
        public string GenerateSource{ get; set; }

        /// <summary>
        /// 电子印章类型：
        /// OFFICIAL-公章；
        /// CONTRACT-合同专用章;
        /// FINANCE-合财务专用章;
        /// PERSONNEL-人事专用章.
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 电子印章图片文件名称，1-50个中文字符。
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
        /// 企业印章横向文字，最多可填15个汉字（若超过印章最大宽度，优先压缩字间距，其次缩小字号）
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
        /// 印章样式:
        /// 
        /// cycle:圆形印章;
        /// ellipse:椭圆印章;
        /// 注：默认圆形印章
        /// </summary>
        [JsonProperty("SealStyle")]
        public string SealStyle{ get; set; }

        /// <summary>
        /// 印章尺寸取值描述：
        /// 42_42 圆形企业公章直径42mm；
        /// 40_40 圆形企业印章直径40mm；
        /// 45_30 椭圆形印章45mm x 30mm;
        /// </summary>
        [JsonProperty("SealSize")]
        public string SealSize{ get; set; }


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
            this.SetParamSimple(map, prefix + "SealStyle", this.SealStyle);
            this.SetParamSimple(map, prefix + "SealSize", this.SealSize);
        }
    }
}

