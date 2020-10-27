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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunOtaVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 固件版本号，格式为x.y.z， x，y 范围0-63，z范围1~524288
        /// </summary>
        [JsonProperty("OtaVersion")]
        public string OtaVersion{ get; set; }

        /// <summary>
        /// 灰度值,取值范围0-100，为0时相当于暂停发布
        /// </summary>
        [JsonProperty("GrayValue")]
        public ulong? GrayValue{ get; set; }

        /// <summary>
        /// 指定的旧版本
        /// </summary>
        [JsonProperty("OldVersions")]
        public string[] OldVersions{ get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 版本发布的描述信息，需要国际化，可以为空
        /// </summary>
        [JsonProperty("Contents")]
        public Contents Contents{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "OtaVersion", this.OtaVersion);
            this.SetParamSimple(map, prefix + "GrayValue", this.GrayValue);
            this.SetParamArraySimple(map, prefix + "OldVersions.", this.OldVersions);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "Contents.", this.Contents);
        }
    }
}

