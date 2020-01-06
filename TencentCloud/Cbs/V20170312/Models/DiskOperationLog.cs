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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskOperationLog : AbstractModel
    {
        
        /// <summary>
        /// 操作者的UIN。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 操作类型。取值范围：
        /// CBS_OPERATION_ATTACH：挂载云硬盘
        /// CBS_OPERATION_DETACH：解挂云硬盘
        /// CBS_OPERATION_RENEW：续费
        /// CBS_OPERATION_EXPAND：扩容
        /// CBS_OPERATION_CREATE：创建
        /// CBS_OPERATION_ISOLATE：隔离
        /// CBS_OPERATION_MODIFY：修改云硬盘属性
        /// ASP_OPERATION_BIND：关联定期快照策略
        /// ASP_OPERATION_UNBIND：取消关联定期快照策略
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 操作的云盘ID。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 操作的状态。取值范围：
        /// SUCCESS :表示操作成功 
        /// FAILED :表示操作失败 
        /// PROCESSING :表示操作中。
        /// </summary>
        [JsonProperty("OperationState")]
        public string OperationState{ get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "OperationState", this.OperationState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

