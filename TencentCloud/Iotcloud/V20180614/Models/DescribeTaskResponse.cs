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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，目前取值为 “UpdateShadow” 或者 “PublishMessage”
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 任务 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 产品 ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 状态。1表示等待处理，2表示调度处理中，3表示已完成，4表示失败，5表示已取消
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 任务创建时间，Unix 时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 最后任务更新时间，Unix 时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 任务完成时间，Unix 时间戳
        /// </summary>
        [JsonProperty("DoneTime")]
        public ulong? DoneTime{ get; set; }

        /// <summary>
        /// 被调度时间，Unix 时间戳
        /// </summary>
        [JsonProperty("ScheduleTime")]
        public ulong? ScheduleTime{ get; set; }

        /// <summary>
        /// 返回的错误码
        /// </summary>
        [JsonProperty("RetCode")]
        public ulong? RetCode{ get; set; }

        /// <summary>
        /// 返回的错误信息
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 完成任务的设备比例
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 匹配到的需执行任务的设备数目
        /// </summary>
        [JsonProperty("AllDeviceCnt")]
        public ulong? AllDeviceCnt{ get; set; }

        /// <summary>
        /// 已完成任务的设备数目
        /// </summary>
        [JsonProperty("DoneDeviceCnt")]
        public ulong? DoneDeviceCnt{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DoneTime", this.DoneTime);
            this.SetParamSimple(map, prefix + "ScheduleTime", this.ScheduleTime);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "AllDeviceCnt", this.AllDeviceCnt);
            this.SetParamSimple(map, prefix + "DoneDeviceCnt", this.DoneDeviceCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

