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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseGWAPI : AbstractModel
    {
        
        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API ID
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// API Path
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// API 类型
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// API 名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// API创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 自定义值通用字段：
        /// Type为1时，该值为空。
        /// Type为2时，该值为容器的代理IP:PORT数组。
        /// </summary>
        [JsonProperty("Custom")]
        public string Custom{ get; set; }

        /// <summary>
        /// 表示是否开启认证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableAuth")]
        public bool? EnableAuth{ get; set; }

        /// <summary>
        /// 云开发环境ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 访问类型（该参数暂不对外暴露）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 统一发布状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnionStatus")]
        public long? UnionStatus{ get; set; }

        /// <summary>
        /// 域名（*表示所有域名）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 是否有路径冲突
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConflictFlag")]
        public bool? ConflictFlag{ get; set; }

        /// <summary>
        /// 域名状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainStatus")]
        public long? DomainStatus{ get; set; }

        /// <summary>
        /// 是否开启路径透传，默认true表示短路径，即不开启(已弃用)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsShortPath")]
        public bool? IsShortPath{ get; set; }

        /// <summary>
        /// 路径透传，默认0关闭，1开启，2关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathTransmission")]
        public ulong? PathTransmission{ get; set; }

        /// <summary>
        /// 跨域校验，默认0开启，1开启，2关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableCheckAcrossDomain")]
        public ulong? EnableCheckAcrossDomain{ get; set; }

        /// <summary>
        /// 静态托管文件目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StaticFileDirectory")]
        public string StaticFileDirectory{ get; set; }

        /// <summary>
        /// QPS策略
        /// </summary>
        [JsonProperty("QPSPolicy")]
        public CloudBaseGWAPIQPSPolicy QPSPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "APIId", this.APIId);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Custom", this.Custom);
            this.SetParamSimple(map, prefix + "EnableAuth", this.EnableAuth);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "UnionStatus", this.UnionStatus);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ConflictFlag", this.ConflictFlag);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "IsShortPath", this.IsShortPath);
            this.SetParamSimple(map, prefix + "PathTransmission", this.PathTransmission);
            this.SetParamSimple(map, prefix + "EnableCheckAcrossDomain", this.EnableCheckAcrossDomain);
            this.SetParamSimple(map, prefix + "StaticFileDirectory", this.StaticFileDirectory);
            this.SetParamObj(map, prefix + "QPSPolicy.", this.QPSPolicy);
        }
    }
}

