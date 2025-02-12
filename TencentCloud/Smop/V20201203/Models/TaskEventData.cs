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

namespace TencentCloud.Smop.V20201203.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskEventData : AbstractModel
    {
        
        /// <summary>
        /// 状态码，0为成功，-1为失败
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 当前完成或正在完成的安心用户运营平台的任务订单ID
        /// </summary>
        [JsonProperty("TaskOrderId")]
        public string TaskOrderId{ get; set; }

        /// <summary>
        /// 当前任务订单状态码。1代表未完成；2代表已完成但未提交任务；3表示已完成，且已提交获得积分任务；4表示过期任务，提交后不获得积分。
        /// </summary>
        [JsonProperty("TaskCode")]
        public long? TaskCode{ get; set; }

        /// <summary>
        /// 获得积分数
        /// </summary>
        [JsonProperty("TaskCoinNumber")]
        public long? TaskCoinNumber{ get; set; }

        /// <summary>
        /// 任务类型后台代码
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 用户的当前积分
        /// </summary>
        [JsonProperty("TotalCoin")]
        public long? TotalCoin{ get; set; }

        /// <summary>
        /// 用户透传的附加数据
        /// </summary>
        [JsonProperty("Attach")]
        public string Attach{ get; set; }

        /// <summary>
        /// 计次任务当前完成次数
        /// </summary>
        [JsonProperty("DoneTimes")]
        public long? DoneTimes{ get; set; }

        /// <summary>
        /// 计次任务当前所需完成次数
        /// </summary>
        [JsonProperty("TotalTimes")]
        public long? TotalTimes{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 用户当前成长值
        /// </summary>
        [JsonProperty("GrowScore")]
        public long? GrowScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskOrderId", this.TaskOrderId);
            this.SetParamSimple(map, prefix + "TaskCode", this.TaskCode);
            this.SetParamSimple(map, prefix + "TaskCoinNumber", this.TaskCoinNumber);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TotalCoin", this.TotalCoin);
            this.SetParamSimple(map, prefix + "Attach", this.Attach);
            this.SetParamSimple(map, prefix + "DoneTimes", this.DoneTimes);
            this.SetParamSimple(map, prefix + "TotalTimes", this.TotalTimes);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "GrowScore", this.GrowScore);
        }
    }
}

