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
        /// 固件任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 固件任务状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 固件任务创建时间，单位：秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 固件任务升级类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 固件任务升级模式。originalVersion（按版本号升级）、filename（提交文件升级）、devicenames（按设备名称升级）
        /// </summary>
        [JsonProperty("UpgradeMode")]
        public string UpgradeMode{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 原始固件版本号，在UpgradeMode是originalVersion升级模式下会返回
        /// </summary>
        [JsonProperty("OriginalVersion")]
        public string OriginalVersion{ get; set; }

        /// <summary>
        /// 创建账号ID
        /// </summary>
        [JsonProperty("CreateUserId")]
        public ulong? CreateUserId{ get; set; }

        /// <summary>
        /// 创建账号ID昵称
        /// </summary>
        [JsonProperty("CreatorNickName")]
        public string CreatorNickName{ get; set; }

        /// <summary>
        /// 延迟时间
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [JsonProperty("TimeoutInterval")]
        public ulong? TimeoutInterval{ get; set; }

        /// <summary>
        /// 静默升级or用户确认升级
        /// </summary>
        [JsonProperty("UpgradeMethod")]
        public ulong? UpgradeMethod{ get; set; }

        /// <summary>
        /// 最大重试次数
        /// </summary>
        [JsonProperty("MaxRetryNum")]
        public ulong? MaxRetryNum{ get; set; }

        /// <summary>
        /// 固件类型
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// 重试间隔时间单位min
        /// </summary>
        [JsonProperty("RetryInterval")]
        public ulong? RetryInterval{ get; set; }

        /// <summary>
        /// 是否覆盖任务
        /// </summary>
        [JsonProperty("OverrideMode")]
        public ulong? OverrideMode{ get; set; }

        /// <summary>
        /// 用户自定义消息
        /// </summary>
        [JsonProperty("TaskUserDefine")]
        public string TaskUserDefine{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

