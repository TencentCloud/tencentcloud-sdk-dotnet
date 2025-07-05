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

namespace TencentCloud.Ape.V20200513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageMarshal : AbstractModel
    {
        
        /// <summary>
        /// 售卖组合唯一标识
        /// </summary>
        [JsonProperty("MarshalId")]
        public ulong? MarshalId{ get; set; }

        /// <summary>
        /// 图片高度
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 图片格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 图片价格(单位:分)
        /// </summary>
        [JsonProperty("Price")]
        public ulong? Price{ get; set; }

        /// <summary>
        /// 授权范围
        /// </summary>
        [JsonProperty("LicenseScope")]
        public string LicenseScope{ get; set; }

        /// <summary>
        /// 是否支持VIP购买
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// 授权范围id
        /// </summary>
        [JsonProperty("LicenseScopeId")]
        public long? LicenseScopeId{ get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        [JsonProperty("DimensionsName")]
        public string DimensionsName{ get; set; }

        /// <summary>
        /// 尺寸id
        /// </summary>
        [JsonProperty("DimensionsNameId")]
        public long? DimensionsNameId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarshalId", this.MarshalId);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "LicenseScope", this.LicenseScope);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "LicenseScopeId", this.LicenseScopeId);
            this.SetParamSimple(map, prefix + "DimensionsName", this.DimensionsName);
            this.SetParamSimple(map, prefix + "DimensionsNameId", this.DimensionsNameId);
        }
    }
}

