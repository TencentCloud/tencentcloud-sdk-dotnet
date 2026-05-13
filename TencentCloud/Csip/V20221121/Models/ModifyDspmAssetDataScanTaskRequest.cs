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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDspmAssetDataScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("AssetIds")]
        public string[] AssetIds{ get; set; }

        /// <summary>
        /// 是否定时任务
        /// </summary>
        [JsonProperty("IsScheduled")]
        public bool? IsScheduled{ get; set; }

        /// <summary>
        /// 是否同意一键授权
        /// </summary>
        [JsonProperty("IsAgreeAuth")]
        public bool? IsAgreeAuth{ get; set; }

        /// <summary>
        /// 是否立即执行
        /// </summary>
        [JsonProperty("IsRunAtOnce")]
        public bool? IsRunAtOnce{ get; set; }

        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 调度周期配置
        /// </summary>
        [JsonProperty("ScheduleConfig")]
        public DspmScheduleConfig ScheduleConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AssetIds.", this.AssetIds);
            this.SetParamSimple(map, prefix + "IsScheduled", this.IsScheduled);
            this.SetParamSimple(map, prefix + "IsAgreeAuth", this.IsAgreeAuth);
            this.SetParamSimple(map, prefix + "IsRunAtOnce", this.IsRunAtOnce);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "ScheduleConfig.", this.ScheduleConfig);
        }
    }
}

