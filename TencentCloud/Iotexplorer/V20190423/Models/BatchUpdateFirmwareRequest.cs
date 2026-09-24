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

    public class BatchUpdateFirmwareRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品ID</p>
        /// </summary>
        [JsonProperty("ProductID")]
        public string ProductID{ get; set; }

        /// <summary>
        /// <p>固件新版本号</p>
        /// </summary>
        [JsonProperty("FirmwareVersion")]
        public string FirmwareVersion{ get; set; }

        /// <summary>
        /// <p>固件原版本号</p>
        /// </summary>
        [JsonProperty("FirmwareOriVersion")]
        public string FirmwareOriVersion{ get; set; }

        /// <summary>
        /// <p>升级方式，0 静默升级  1 用户确认升级。 不填默认为静默升级方式</p>
        /// </summary>
        [JsonProperty("UpgradeMethod")]
        public ulong? UpgradeMethod{ get; set; }

        /// <summary>
        /// <p>设备列表文件名称，根据文件列表升级固件需要填写此参数</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>设备列表的文件md5值</p>
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// <p>设备列表的文件大小值</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// <p>需要升级的设备名称列表</p>
        /// </summary>
        [JsonProperty("DeviceNames")]
        public string[] DeviceNames{ get; set; }

        /// <summary>
        /// <p>固件升级任务，默认超时时间。 最小取值120秒，最大为900秒</p>
        /// </summary>
        [JsonProperty("TimeoutInterval")]
        public ulong? TimeoutInterval{ get; set; }

        /// <summary>
        /// <p>固件升级任务类型，默认静态升级值为空或1，动态升级值为7</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>任务延迟时间</p>
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// <p>是否覆盖，0不覆盖，1覆盖</p>
        /// </summary>
        [JsonProperty("OverrideMode")]
        public ulong? OverrideMode{ get; set; }

        /// <summary>
        /// <p>失败重试次数</p>
        /// </summary>
        [JsonProperty("MaxRetryNum")]
        public ulong? MaxRetryNum{ get; set; }

        /// <summary>
        /// <p>重试间隔min</p>
        /// </summary>
        [JsonProperty("RetryInterval")]
        public ulong? RetryInterval{ get; set; }

        /// <summary>
        /// <p>固件模块</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>用户自定义信息</p>
        /// </summary>
        [JsonProperty("TaskUserDefine")]
        public string TaskUserDefine{ get; set; }

        /// <summary>
        /// <p>每分钟下发设备量</p>
        /// </summary>
        [JsonProperty("RateLimit")]
        public long? RateLimit{ get; set; }

        /// <summary>
        /// <p>任务截止时间，Unix 时间戳（单位：秒）。传入 0 或不传表示不设截止，任务按原重试/超时策略执行完毕。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>任务开始调度时间，Unix 时间戳（单位：秒）。传入 0 或不传时任务立即创建执行，与 DelayTime 同时传入时，本参数优先生效。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamSimple(map, prefix + "FirmwareVersion", this.FirmwareVersion);
            this.SetParamSimple(map, prefix + "FirmwareOriVersion", this.FirmwareOriVersion);
            this.SetParamSimple(map, prefix + "UpgradeMethod", this.UpgradeMethod);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamArraySimple(map, prefix + "DeviceNames.", this.DeviceNames);
            this.SetParamSimple(map, prefix + "TimeoutInterval", this.TimeoutInterval);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "OverrideMode", this.OverrideMode);
            this.SetParamSimple(map, prefix + "MaxRetryNum", this.MaxRetryNum);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "TaskUserDefine", this.TaskUserDefine);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

