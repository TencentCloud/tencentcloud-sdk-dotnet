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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanSetInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务状态: 1-已完成,2-处理中,3-处理出错,4-处理超时
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// app信息
        /// </summary>
        [JsonProperty("AppDetailInfo")]
        public AppDetailInfo AppDetailInfo{ get; set; }

        /// <summary>
        /// 病毒信息
        /// </summary>
        [JsonProperty("VirusInfo")]
        public VirusInfo VirusInfo{ get; set; }

        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonProperty("VulInfo")]
        public VulInfo VulInfo{ get; set; }

        /// <summary>
        /// 广告插件信息
        /// </summary>
        [JsonProperty("AdInfo")]
        public AdInfo AdInfo{ get; set; }

        /// <summary>
        /// 提交扫描的时间
        /// </summary>
        [JsonProperty("TaskTime")]
        public ulong? TaskTime{ get; set; }

        /// <summary>
        /// 状态码，成功返回0，失败返回错误码
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong? StatusCode{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 状态操作指引
        /// </summary>
        [JsonProperty("StatusRef")]
        public string StatusRef{ get; set; }

        /// <summary>
        /// 系统权限信息
        /// </summary>
        [JsonProperty("PermissionInfo")]
        public ScanPermissionList PermissionInfo{ get; set; }

        /// <summary>
        /// 敏感词列表
        /// </summary>
        [JsonProperty("SensitiveInfo")]
        public ScanSensitiveList SensitiveInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamObj(map, prefix + "AppDetailInfo.", this.AppDetailInfo);
            this.SetParamObj(map, prefix + "VirusInfo.", this.VirusInfo);
            this.SetParamObj(map, prefix + "VulInfo.", this.VulInfo);
            this.SetParamObj(map, prefix + "AdInfo.", this.AdInfo);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StatusRef", this.StatusRef);
            this.SetParamObj(map, prefix + "PermissionInfo.", this.PermissionInfo);
            this.SetParamObj(map, prefix + "SensitiveInfo.", this.SensitiveInfo);
        }
    }
}

