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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoGroupInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// RO 组的 ID。
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// RO 组的详细信息。
        /// </summary>
        [JsonProperty("RoGroupInfo")]
        public RoGroupAttr RoGroupInfo{ get; set; }

        /// <summary>
        /// RO 组内实例的权重。若修改 RO 组的权重模式为用户自定义模式（custom），则必须设置该参数，且需要设置每个 RO 实例的权重值。
        /// </summary>
        [JsonProperty("RoWeightValues")]
        public RoWeightValue[] RoWeightValues{ get; set; }

        /// <summary>
        /// 是否重新均衡 RO 组内的 RO 实例的负载。支持值包括：1 - 重新均衡负载；0 - 不重新均衡负载。默认值为 0。注意，设置为重新均衡负载是，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库。
        /// </summary>
        [JsonProperty("IsBalanceRoLoad")]
        public long? IsBalanceRoLoad{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
            this.SetParamObj(map, prefix + "RoGroupInfo.", this.RoGroupInfo);
            this.SetParamArrayObj(map, prefix + "RoWeightValues.", this.RoWeightValues);
            this.SetParamSimple(map, prefix + "IsBalanceRoLoad", this.IsBalanceRoLoad);
        }
    }
}

