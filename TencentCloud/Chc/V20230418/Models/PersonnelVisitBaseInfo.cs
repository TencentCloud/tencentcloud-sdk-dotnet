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

    public class PersonnelVisitBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 到访原因。到访原因，映射关系：DEVICE_MAINTENANCE 设备维护 DEVICE_MOVE 设备收货上下架 CHECK 盘点 OTHER 其他
        /// </summary>
        [JsonProperty("VisitReason")]
        public string[] VisitReason{ get; set; }

        /// <summary>
        /// 到访原因
        /// </summary>
        [JsonProperty("VisitRemark")]
        public string VisitRemark{ get; set; }

        /// <summary>
        /// 到访结束时间
        /// </summary>
        [JsonProperty("EnterStartTime")]
        public string EnterStartTime{ get; set; }

        /// <summary>
        /// 到访开始时间
        /// </summary>
        [JsonProperty("EnterEndTime")]
        public string EnterEndTime{ get; set; }

        /// <summary>
        /// 机房管理单元列表
        /// </summary>
        [JsonProperty("IdcUnitNameList")]
        public string[] IdcUnitNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamArraySimple(map, prefix + "VisitReason.", this.VisitReason);
            this.SetParamSimple(map, prefix + "VisitRemark", this.VisitRemark);
            this.SetParamSimple(map, prefix + "EnterStartTime", this.EnterStartTime);
            this.SetParamSimple(map, prefix + "EnterEndTime", this.EnterEndTime);
            this.SetParamArraySimple(map, prefix + "IdcUnitNameList.", this.IdcUnitNameList);
        }
    }
}

