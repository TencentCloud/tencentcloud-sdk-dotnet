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

    public class RestoreTask : AbstractModel
    {
        
        /// <summary>
        /// 目标实例ID
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// 目标实例名称
        /// </summary>
        [JsonProperty("TargetInstanceName")]
        public string TargetInstanceName{ get; set; }

        /// <summary>
        /// 目标实例状态。取值范围：
        /// 1：申请中
        /// 2：运行中
        /// 3：受限运行中 (主备切换中)
        /// 4：已隔离
        /// 5：回收中
        /// 6：已回收
        /// 7：任务执行中 (实例做备份、回档等操作)
        /// 8：已下线
        /// 9：实例扩容中
        /// 10：实例迁移中
        /// 11：只读
        /// 12：重启中
        /// </summary>
        [JsonProperty("TargetInstanceStatus")]
        public long? TargetInstanceStatus{ get; set; }

        /// <summary>
        /// 目标实例所在地域
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// 回档记录ID
        /// </summary>
        [JsonProperty("RestoreId")]
        public long? RestoreId{ get; set; }

        /// <summary>
        /// 回档到目标实例的类型，0-当前实例，1-已有实例，2-全新实例
        /// </summary>
        [JsonProperty("TargetType")]
        public long? TargetType{ get; set; }

        /// <summary>
        /// 回档方式，0-按照时间点回档，1-按照备份集回档
        /// </summary>
        [JsonProperty("RestoreType")]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// 回档目标时间
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 回档状态，0-初始化，1-运行中，2-成功，3-失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamSimple(map, prefix + "TargetInstanceName", this.TargetInstanceName);
            this.SetParamSimple(map, prefix + "TargetInstanceStatus", this.TargetInstanceStatus);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "RestoreId", this.RestoreId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "RestoreType", this.RestoreType);
            this.SetParamSimple(map, prefix + "RestoreTime", this.RestoreTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

