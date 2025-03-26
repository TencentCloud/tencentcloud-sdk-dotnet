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

    public class WorkOrderTypeDetail : AbstractModel
    {
        
        /// <summary>
        /// 工单类型所属的大类
        /// </summary>
        [JsonProperty("WorkOrderFamily")]
        public string WorkOrderFamily{ get; set; }

        /// <summary>
        /// 工单类型名称
        /// </summary>
        [JsonProperty("WorkOrderName")]
        public string WorkOrderName{ get; set; }

        /// <summary>
        /// 工单类型的唯一英文标识
        /// </summary>
        [JsonProperty("WorkOrderType")]
        public string WorkOrderType{ get; set; }

        /// <summary>
        /// 工单类型简述
        /// </summary>
        [JsonProperty("WorkOrderDescription")]
        public string WorkOrderDescription{ get; set; }

        /// <summary>
        /// 是否被收藏
        /// </summary>
        [JsonProperty("CollectFlag")]
        public bool? CollectFlag{ get; set; }

        /// <summary>
        /// 服务时效
        /// </summary>
        [JsonProperty("SlaMessage")]
        public string SlaMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkOrderFamily", this.WorkOrderFamily);
            this.SetParamSimple(map, prefix + "WorkOrderName", this.WorkOrderName);
            this.SetParamSimple(map, prefix + "WorkOrderType", this.WorkOrderType);
            this.SetParamSimple(map, prefix + "WorkOrderDescription", this.WorkOrderDescription);
            this.SetParamSimple(map, prefix + "CollectFlag", this.CollectFlag);
            this.SetParamSimple(map, prefix + "SlaMessage", this.SlaMessage);
        }
    }
}

