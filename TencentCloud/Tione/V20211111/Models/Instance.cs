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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 资源组节点id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点已用资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedResource")]
        public ResourceInfo UsedResource{ get; set; }

        /// <summary>
        /// 节点总资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalResource")]
        public ResourceInfo TotalResource{ get; set; }

        /// <summary>
        /// 节点状态 
        /// 注意：此字段为枚举值
        /// 说明: 
        /// DEPLOYING: 部署中
        /// RUNNING: 运行中 
        /// DEPLOY_FAILED: 部署失败
        ///  RELEASING 释放中 
        /// RELEASED：已释放 
        /// EXCEPTION：异常
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 创建时间: 
        /// 注意：北京时间，比如: 2021-12-01 12:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// 注意：北京时间，比如：2021-12-11 12:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 自动续费标识
        /// 注意：此字段为枚举值
        /// 说明：
        /// NOTIFY_AND_MANUAL_RENEW：手动续费(取消自动续费)且到期通知
        /// NOTIFY_AND_AUTO_RENEW：自动续费且到期通知
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW：手动续费(取消自动续费)且到期不通知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public string AutoRenewFlag{ get; set; }

        /// <summary>
        /// 计费项ID
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// 计费项别名
        /// </summary>
        [JsonProperty("SpecAlias")]
        public string SpecAlias{ get; set; }

        /// <summary>
        /// 计费项特性列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecFeatures")]
        public string[] SpecFeatures{ get; set; }

        /// <summary>
        /// 纳管cvmid
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "UsedResource.", this.UsedResource);
            this.SetParamObj(map, prefix + "TotalResource.", this.TotalResource);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "SpecAlias", this.SpecAlias);
            this.SetParamArraySimple(map, prefix + "SpecFeatures.", this.SpecFeatures);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
        }
    }
}

