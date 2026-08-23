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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRegistryScanTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>定时扫描任务id</p>
        /// </summary>
        [JsonProperty("TimedScanConfigId")]
        public ulong? TimedScanConfigId{ get; set; }

        /// <summary>
        /// <p>自动匹配模式</p><p>枚举值：</p><ul><li>BY_CLUSTER： 按集群选择</li><li>LATEST_VERSION： 仅扫描最新版本镜像</li><li>LOCAL_IMAGE： 本地镜像</li></ul>
        /// </summary>
        [JsonProperty("AutoMatchMode")]
        public string[] AutoMatchMode{ get; set; }

        /// <summary>
        /// <p>扫描资产模式</p><p>枚举值：</p><ul><li>ALL： 全部</li><li>MANUAL： 手动选择</li><li>AUTO_MATCH： 自动匹配</li></ul>
        /// </summary>
        [JsonProperty("ScopeMode")]
        public string ScopeMode{ get; set; }

        /// <summary>
        /// <p>任务触发类型</p><p>枚举值：</p><ul><li>TIMED： 定时任务</li><li>MANUAL： 手动触发</li></ul>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>扫描类别</p><p>枚举值：</p><ul><li>CVE： 漏洞</li><li>RISK： 风险</li><li>VIRUS： 木马</li></ul>
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// <p>扫描的镜像id</p>
        /// </summary>
        [JsonProperty("ImageIds")]
        public ulong?[] ImageIds{ get; set; }

        /// <summary>
        /// <p>任务状态</p><p>枚举值：</p><ul><li>RUNNING： 执行中</li><li>SUCCESS： 任务成功</li><li>TIMEOUT： 任务超时</li><li>FAILED： 任务失败</li><li>CANCELLED： 已取消</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>定时任务所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>定时任务所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>定时任务所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>扫描镜像数</p>
        /// </summary>
        [JsonProperty("ScanImageCount")]
        public ulong? ScanImageCount{ get; set; }

        /// <summary>
        /// <p>扫描成功镜像数</p>
        /// </summary>
        [JsonProperty("SuccessImageCount")]
        public ulong? SuccessImageCount{ get; set; }

        /// <summary>
        /// <p>扫描失败镜像数</p>
        /// </summary>
        [JsonProperty("FailureImageCount")]
        public ulong? FailureImageCount{ get; set; }

        /// <summary>
        /// <p>任务忽略的镜像数</p>
        /// </summary>
        [JsonProperty("IgnoredImageCount")]
        public ulong? IgnoredImageCount{ get; set; }

        /// <summary>
        /// <p>任务被取消镜像数</p>
        /// </summary>
        [JsonProperty("CancelledImageCount")]
        public ulong? CancelledImageCount{ get; set; }

        /// <summary>
        /// <p>扫描启动时间</p><p>参数格式：hh:mm</p>
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public string ScanStartTime{ get; set; }

        /// <summary>
        /// <p>扫描停止时间</p><p>参数格式：hh:mm</p>
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// <p>超时时间，单位秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>任务取消原因</p>
        /// </summary>
        [JsonProperty("CancelReason")]
        public string CancelReason{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>扫描任务调度配置</p>
        /// </summary>
        [JsonProperty("Schedule")]
        public ImageScanScheduleConfig Schedule{ get; set; }

        /// <summary>
        /// <p>扫描任务目标</p>
        /// </summary>
        [JsonProperty("Target")]
        public ImageScanAssetTarget Target{ get; set; }

        /// <summary>
        /// <p>扫描任务过滤配置</p>
        /// </summary>
        [JsonProperty("Filter")]
        public ImageScanRegistryFilter Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TimedScanConfigId", this.TimedScanConfigId);
            this.SetParamArraySimple(map, prefix + "AutoMatchMode.", this.AutoMatchMode);
            this.SetParamSimple(map, prefix + "ScopeMode", this.ScopeMode);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ScanImageCount", this.ScanImageCount);
            this.SetParamSimple(map, prefix + "SuccessImageCount", this.SuccessImageCount);
            this.SetParamSimple(map, prefix + "FailureImageCount", this.FailureImageCount);
            this.SetParamSimple(map, prefix + "IgnoredImageCount", this.IgnoredImageCount);
            this.SetParamSimple(map, prefix + "CancelledImageCount", this.CancelledImageCount);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "CancelReason", this.CancelReason);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Schedule.", this.Schedule);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
        }
    }
}

