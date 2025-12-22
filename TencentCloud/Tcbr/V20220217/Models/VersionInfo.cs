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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VersionInfo : AbstractModel
    {
        
        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 流量比例
        /// </summary>
        [JsonProperty("FlowRatio")]
        public long? FlowRatio{ get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 构建Id
        /// </summary>
        [JsonProperty("BuildId")]
        public long? BuildId{ get; set; }

        /// <summary>
        /// 上传方式
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// 操作标识
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 测试参数
        /// </summary>
        [JsonProperty("UrlParam")]
        public ObjectKV UrlParam{ get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        [JsonProperty("IsDefaultPriority")]
        public bool? IsDefaultPriority{ get; set; }

        /// <summary>
        /// 流量参数
        /// </summary>
        [JsonProperty("FlowParams")]
        public ObjectKVPriority[] FlowParams{ get; set; }

        /// <summary>
        /// 最小副本数
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// 操作Id
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// 百分比
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// 当前副本数
        /// </summary>
        [JsonProperty("CurrentReplicas")]
        public long? CurrentReplicas{ get; set; }

        /// <summary>
        /// 架构类型
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "FlowRatio", this.FlowRatio);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "BuildId", this.BuildId);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "UrlParam.", this.UrlParam);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "IsDefaultPriority", this.IsDefaultPriority);
            this.SetParamArrayObj(map, prefix + "FlowParams.", this.FlowParams);
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CurrentReplicas", this.CurrentReplicas);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
        }
    }
}

