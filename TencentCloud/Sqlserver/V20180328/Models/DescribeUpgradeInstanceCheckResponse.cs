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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUpgradeInstanceCheckResponse : AbstractModel
    {
        
        /// <summary>
        /// 本变配是否对实例有影响，0-没有影响 1-有影响
        /// </summary>
        [JsonProperty("IsAffect")]
        public long? IsAffect{ get; set; }

        /// <summary>
        /// 本变配是否可以执行 0-不通过，不能变配 1-通过，可以变配
        /// </summary>
        [JsonProperty("Passed")]
        public long? Passed{ get; set; }

        /// <summary>
        /// 本变配是升配还是降配，down-降配 up-升配
        /// </summary>
        [JsonProperty("ModifyMode")]
        public string ModifyMode{ get; set; }

        /// <summary>
        /// 检查项列表
        /// </summary>
        [JsonProperty("CheckItems")]
        public CheckItem[] CheckItems{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAffect", this.IsAffect);
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamSimple(map, prefix + "ModifyMode", this.ModifyMode);
            this.SetParamArrayObj(map, prefix + "CheckItems.", this.CheckItems);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

