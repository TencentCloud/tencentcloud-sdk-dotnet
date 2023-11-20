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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddEditImageAutoAuthorizedRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 授权范围类别，MANUAL:自选主机节点，ALL:全部镜像
        /// </summary>
        [JsonProperty("RangeType")]
        public string RangeType{ get; set; }

        /// <summary>
        /// 每天最大的镜像授权数限制, 0表示无限制
        /// </summary>
        [JsonProperty("MaxDailyCount")]
        public long? MaxDailyCount{ get; set; }

        /// <summary>
        /// 规则是否生效，0:不生效，1:已生效
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// 自选主机id，当授权范围为MANUAL:自选主机时且HostIdFilters为空时，必填
        /// </summary>
        [JsonProperty("HostIdSet")]
        public string[] HostIdSet{ get; set; }

        /// <summary>
        /// 规则id，在编辑时，必填
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 根据条件过滤，当授权范围为MANUAL:自选主机时且HostIdSet为空时，必填
        /// </summary>
        [JsonProperty("HostIdFilters")]
        public AssetFilters[] HostIdFilters{ get; set; }

        /// <summary>
        /// 根据条件过滤而且排除指定主机id
        /// </summary>
        [JsonProperty("ExcludeHostIdSet")]
        public string[] ExcludeHostIdSet{ get; set; }

        /// <summary>
        /// 自动扫描开关
        /// </summary>
        [JsonProperty("AutoScanEnabled")]
        public long? AutoScanEnabled{ get; set; }

        /// <summary>
        /// 自动扫描范围
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "MaxDailyCount", this.MaxDailyCount);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamArraySimple(map, prefix + "HostIdSet.", this.HostIdSet);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "HostIdFilters.", this.HostIdFilters);
            this.SetParamArraySimple(map, prefix + "ExcludeHostIdSet.", this.ExcludeHostIdSet);
            this.SetParamSimple(map, prefix + "AutoScanEnabled", this.AutoScanEnabled);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
        }
    }
}

