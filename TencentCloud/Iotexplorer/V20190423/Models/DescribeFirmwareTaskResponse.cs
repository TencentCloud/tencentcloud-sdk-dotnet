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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFirmwareTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>固件任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>固件任务状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>固件任务创建时间，单位：秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>固件任务升级类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>产品名称</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>固件任务升级模式。originalVersion（按版本号升级）、filename（提交文件升级）、devicenames（按设备名称升级）</p>
        /// </summary>
        [JsonProperty("UpgradeMode")]
        public string UpgradeMode{ get; set; }

        /// <summary>
        /// <p>产品ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>原始固件版本号，在UpgradeMode是originalVersion升级模式下会返回</p>
        /// </summary>
        [JsonProperty("OriginalVersion")]
        public string OriginalVersion{ get; set; }

        /// <summary>
        /// <p>创建账号ID</p>
        /// </summary>
        [JsonProperty("CreateUserId")]
        public ulong? CreateUserId{ get; set; }

        /// <summary>
        /// <p>创建账号ID昵称</p>
        /// </summary>
        [JsonProperty("CreatorNickName")]
        public string CreatorNickName{ get; set; }

        /// <summary>
        /// <p>延迟时间</p>
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// <p>超时时间</p>
        /// </summary>
        [JsonProperty("TimeoutInterval")]
        public ulong? TimeoutInterval{ get; set; }

        /// <summary>
        /// <p>静默升级or用户确认升级</p>
        /// </summary>
        [JsonProperty("UpgradeMethod")]
        public ulong? UpgradeMethod{ get; set; }

        /// <summary>
        /// <p>最大重试次数</p>
        /// </summary>
        [JsonProperty("MaxRetryNum")]
        public ulong? MaxRetryNum{ get; set; }

        /// <summary>
        /// <p>固件类型</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>重试间隔时间单位min</p>
        /// </summary>
        [JsonProperty("RetryInterval")]
        public ulong? RetryInterval{ get; set; }

        /// <summary>
        /// <p>是否覆盖任务</p>
        /// </summary>
        [JsonProperty("OverrideMode")]
        public ulong? OverrideMode{ get; set; }

        /// <summary>
        /// <p>用户自定义消息</p>
        /// </summary>
        [JsonProperty("TaskUserDefine")]
        public string TaskUserDefine{ get; set; }

        /// <summary>
        /// <p>每分钟发送设备量</p>
        /// </summary>
        [JsonProperty("RateLimit")]
        public long? RateLimit{ get; set; }

        /// <summary>
        /// <p>任务截止时间，Unix 时间戳（单位：秒）。传入 0 或不传表示不设截止，任务按原重试/超时策略执行完毕。 </p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>任务开始调度时间，Unix 时间戳（单位：秒）。传入 0 或不传时任务立即创建执行，与 DelayTime 同时传入时，本参数优先生效。 </p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "UpgradeMode", this.UpgradeMode);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "OriginalVersion", this.OriginalVersion);
            this.SetParamSimple(map, prefix + "CreateUserId", this.CreateUserId);
            this.SetParamSimple(map, prefix + "CreatorNickName", this.CreatorNickName);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "TimeoutInterval", this.TimeoutInterval);
            this.SetParamSimple(map, prefix + "UpgradeMethod", this.UpgradeMethod);
            this.SetParamSimple(map, prefix + "MaxRetryNum", this.MaxRetryNum);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "OverrideMode", this.OverrideMode);
            this.SetParamSimple(map, prefix + "TaskUserDefine", this.TaskUserDefine);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

