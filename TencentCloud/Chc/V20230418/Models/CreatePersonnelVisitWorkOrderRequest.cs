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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonnelVisitWorkOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 到访人员信息
        /// </summary>
        [JsonProperty("PersonnelSet")]
        public Personnel[] PersonnelSet{ get; set; }

        /// <summary>
        /// 机房 ID
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 机房管理单元列表
        /// </summary>
        [JsonProperty("IdcUnitIdSet")]
        public ulong?[] IdcUnitIdSet{ get; set; }

        /// <summary>
        /// 到访开始时间
        /// </summary>
        [JsonProperty("EnterStartTime")]
        public string EnterStartTime{ get; set; }

        /// <summary>
        /// 到访结束时间
        /// </summary>
        [JsonProperty("EnterEndTime")]
        public string EnterEndTime{ get; set; }

        /// <summary>
        /// 到访原因，映射关系：IT_OPERATION IT运维 OTHER 其他
        /// </summary>
        [JsonProperty("VisitReason")]
        public string[] VisitReason{ get; set; }

        /// <summary>
        /// 到访说明
        /// </summary>
        [JsonProperty("VisitRemark")]
        public string VisitRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PersonnelSet.", this.PersonnelSet);
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamArraySimple(map, prefix + "IdcUnitIdSet.", this.IdcUnitIdSet);
            this.SetParamSimple(map, prefix + "EnterStartTime", this.EnterStartTime);
            this.SetParamSimple(map, prefix + "EnterEndTime", this.EnterEndTime);
            this.SetParamArraySimple(map, prefix + "VisitReason.", this.VisitReason);
            this.SetParamSimple(map, prefix + "VisitRemark", this.VisitRemark);
        }
    }
}

