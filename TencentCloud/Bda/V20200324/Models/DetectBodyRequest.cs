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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectBodyRequest : AbstractModel
    {
        
        /// <summary>
        /// 人体图片 Base64 数据。
        /// 图片 base64 编码后大小不可超过5M。
        /// 图片分辨率不得超过 2048*2048。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 人体图片 Url 。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。
        /// 图片 base64 编码后大小不可超过5M。 
        /// 图片分辨率不得超过 2048*2048。
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 最多检测的人体数目，默认值为1（仅检测图片中面积最大的那个人体）； 最大值10 ，检测图片中面积最大的10个人体。
        /// </summary>
        [JsonProperty("MaxBodyNum")]
        public ulong? MaxBodyNum{ get; set; }

        /// <summary>
        /// 是否返回年龄、性别、朝向等属性。 
        /// 可选项有 Age、Bag、Gender、UpperBodyCloth、LowerBodyCloth、Orientation。  
        /// 如果此参数为空则为不需要返回。 
        /// 需要将属性组成一个用逗号分隔的字符串，属性之间的顺序没有要求。 
        /// 关于各属性的详细描述，参见下文出参。 
        /// 最多返回面积最大的 5 个人体属性信息，超过 5 个人体（第 6 个及以后的人体）的 BodyAttributesInfo 不具备参考意义。
        /// </summary>
        [JsonProperty("AttributesOptions")]
        public AttributesOptions AttributesOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "MaxBodyNum", this.MaxBodyNum);
            this.SetParamObj(map, prefix + "AttributesOptions.", this.AttributesOptions);
        }
    }
}

