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

    public class AppScanSet : AbstractModel
    {
        
        /// <summary>
        /// 任务唯一标识
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// app的名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// app的包名
        /// </summary>
        [JsonProperty("AppPkgName")]
        public string AppPkgName{ get; set; }

        /// <summary>
        /// app的版本号
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// app的md5
        /// </summary>
        [JsonProperty("AppMd5")]
        public string AppMd5{ get; set; }

        /// <summary>
        /// app的大小
        /// </summary>
        [JsonProperty("AppSize")]
        public ulong? AppSize{ get; set; }

        /// <summary>
        /// 扫描结果返回码
        /// </summary>
        [JsonProperty("ScanCode")]
        public ulong? ScanCode{ get; set; }

        /// <summary>
        /// 任务状态: 1-已完成,2-处理中,3-处理出错,4-处理超时
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// 提交扫描时间
        /// </summary>
        [JsonProperty("TaskTime")]
        public ulong? TaskTime{ get; set; }

        /// <summary>
        /// app的图标url
        /// </summary>
        [JsonProperty("AppIconUrl")]
        public string AppIconUrl{ get; set; }

        /// <summary>
        /// 标识唯一该app，主要用于删除
        /// </summary>
        [JsonProperty("AppSid")]
        public string AppSid{ get; set; }

        /// <summary>
        /// 安全类型:1-安全软件，2-风险软件，3病毒软件
        /// </summary>
        [JsonProperty("SafeType")]
        public ulong? SafeType{ get; set; }

        /// <summary>
        /// 漏洞个数
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppPkgName", this.AppPkgName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "AppMd5", this.AppMd5);
            this.SetParamSimple(map, prefix + "AppSize", this.AppSize);
            this.SetParamSimple(map, prefix + "ScanCode", this.ScanCode);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
            this.SetParamSimple(map, prefix + "AppIconUrl", this.AppIconUrl);
            this.SetParamSimple(map, prefix + "AppSid", this.AppSid);
            this.SetParamSimple(map, prefix + "SafeType", this.SafeType);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
        }
    }
}

