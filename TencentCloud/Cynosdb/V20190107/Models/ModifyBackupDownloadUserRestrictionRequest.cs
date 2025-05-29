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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupDownloadUserRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// 下载限制类型，NoLimit-不限制,LimitOnlyIntranet-限制内网 ,Customize-自定义
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// 该参数仅支持 In， 表示 LimitVpc 指定的vpc可以下载。默认为In
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// In: 指定的ip可以下载； NotIn: 指定的ip不可以下载
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// 限制下载的vpc设置
        /// </summary>
        [JsonProperty("LimitVpcs")]
        public BackupLimitVpcItem[] LimitVpcs{ get; set; }

        /// <summary>
        /// 限制下载的ip设置
        /// </summary>
        [JsonProperty("LimitIps")]
        public string[] LimitIps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpcs.", this.LimitVpcs);
            this.SetParamArraySimple(map, prefix + "LimitIps.", this.LimitIps);
        }
    }
}

