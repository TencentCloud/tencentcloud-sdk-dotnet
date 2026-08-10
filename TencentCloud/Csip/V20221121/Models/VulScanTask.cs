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

    public class VulScanTask : AbstractModel
    {
        
        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>任务所属用户appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>任务类型</p><p>枚举值：</p><ul><li>0： 一键扫描</li><li>1： 周期扫描</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// <p>漏洞分类</p><p>枚举值：</p><ul><li>LINUX： Linux软件漏洞</li><li>WINDOWS： Windows系统补丁</li><li>WEB_CMS： Web-CMS漏洞</li><li>APPLICATION： 应用漏洞</li><li>EMERGENCY： 应急漏洞</li></ul>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// <p>漏洞名称</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string[] VulName{ get; set; }

        /// <summary>
        /// <p>kb名称</p>
        /// </summary>
        [JsonProperty("KbName")]
        public string[] KbName{ get; set; }

        /// <summary>
        /// <p>是否应急漏洞</p><p>枚举值：</p><ul><li>0： 否</li><li>1： 是</li></ul>
        /// </summary>
        [JsonProperty("Emergency")]
        public ulong? Emergency{ get; set; }

        /// <summary>
        /// <p>扫描账号数量（0: 全部账号, others: 账号数量）</p>
        /// </summary>
        [JsonProperty("Account")]
        public ulong? Account{ get; set; }

        /// <summary>
        /// <p>扫描开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>扫描结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>扫描状态（INITIALIZING: 初始化, SCANNING: 扫描中, SUCCESS: 扫描成功,  TOTAL_FAIL: 全部扫描失败）</p><p>枚举值：</p><ul><li>STOPPED： 已停止</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>漏洞威胁等级</p><p>枚举值：</p><ul><li>LOW： 低危</li><li>MEDIUM： 中危</li><li>HIGH： 高危</li><li>CRITICAL： 严重</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string[] Level{ get; set; }

        /// <summary>
        /// <p>扫描方式</p><p>枚举值：</p><ul><li>VersionCompare： 版本对比</li><li>POC： POC检测</li><li>VersionComparePOC： 版本对比+POC检测</li></ul>
        /// </summary>
        [JsonProperty("Method")]
        public string[] Method{ get; set; }

        /// <summary>
        /// <p>资产列表</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }

        /// <summary>
        /// <p>资产范围</p><p>枚举值：</p><ul><li>0： 所有资产</li><li>1： 自选资产</li><li>2： 自选排除资产</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public ulong? AssetRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamArraySimple(map, prefix + "VulName.", this.VulName);
            this.SetParamArraySimple(map, prefix + "KbName.", this.KbName);
            this.SetParamSimple(map, prefix + "Emergency", this.Emergency);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Level.", this.Level);
            this.SetParamArraySimple(map, prefix + "Method.", this.Method);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
        }
    }
}

