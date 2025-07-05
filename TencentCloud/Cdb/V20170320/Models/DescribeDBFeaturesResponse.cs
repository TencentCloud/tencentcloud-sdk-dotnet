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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBFeaturesResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否支持数据库审计功能。
        /// </summary>
        [JsonProperty("IsSupportAudit")]
        public bool? IsSupportAudit{ get; set; }

        /// <summary>
        /// 开启审计是否需要升级内核版本。
        /// </summary>
        [JsonProperty("AuditNeedUpgrade")]
        public bool? AuditNeedUpgrade{ get; set; }

        /// <summary>
        /// 是否支持数据库加密功能。
        /// </summary>
        [JsonProperty("IsSupportEncryption")]
        public bool? IsSupportEncryption{ get; set; }

        /// <summary>
        /// 开启加密是否需要升级内核版本。
        /// </summary>
        [JsonProperty("EncryptionNeedUpgrade")]
        public bool? EncryptionNeedUpgrade{ get; set; }

        /// <summary>
        /// 是否为异地只读实例。
        /// </summary>
        [JsonProperty("IsRemoteRo")]
        public bool? IsRemoteRo{ get; set; }

        /// <summary>
        /// 主实例所在地域。
        /// 说明：此参数可能返回空值，您可忽略此出参返回值。如需获取实例所在地域详情，您可调用 [查询实例列表](https://cloud.tencent.com/document/product/236/15872) 接口查询。
        /// </summary>
        [JsonProperty("MasterRegion")]
        public string MasterRegion{ get; set; }

        /// <summary>
        /// 是否支持小版本升级。
        /// </summary>
        [JsonProperty("IsSupportUpdateSubVersion")]
        public bool? IsSupportUpdateSubVersion{ get; set; }

        /// <summary>
        /// 当前内核版本。
        /// </summary>
        [JsonProperty("CurrentSubVersion")]
        public string CurrentSubVersion{ get; set; }

        /// <summary>
        /// 可供升级的内核版本。
        /// </summary>
        [JsonProperty("TargetSubVersion")]
        public string TargetSubVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSupportAudit", this.IsSupportAudit);
            this.SetParamSimple(map, prefix + "AuditNeedUpgrade", this.AuditNeedUpgrade);
            this.SetParamSimple(map, prefix + "IsSupportEncryption", this.IsSupportEncryption);
            this.SetParamSimple(map, prefix + "EncryptionNeedUpgrade", this.EncryptionNeedUpgrade);
            this.SetParamSimple(map, prefix + "IsRemoteRo", this.IsRemoteRo);
            this.SetParamSimple(map, prefix + "MasterRegion", this.MasterRegion);
            this.SetParamSimple(map, prefix + "IsSupportUpdateSubVersion", this.IsSupportUpdateSubVersion);
            this.SetParamSimple(map, prefix + "CurrentSubVersion", this.CurrentSubVersion);
            this.SetParamSimple(map, prefix + "TargetSubVersion", this.TargetSubVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

