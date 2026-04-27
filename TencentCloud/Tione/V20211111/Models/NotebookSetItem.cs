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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotebookSetItem : AbstractModel
    {
        
        /// <summary>
        /// <p>notebook ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>notebook 名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>计费模式</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConf")]
        public ResourceConf ResourceConf{ get; set; }

        /// <summary>
        /// <p>预付费资源组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>存储卷大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// <p>计费金额信息，eg：2.00元/小时 (for后付费)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInfos")]
        public string[] BillingInfos{ get; set; }

        /// <summary>
        /// <p>标签配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>启动时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>运行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeInSeconds")]
        public ulong? RuntimeInSeconds{ get; set; }

        /// <summary>
        /// <p>计费状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public string ChargeStatus{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>错误原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Pod名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>后付费资源规格名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTypeAlias")]
        public string InstanceTypeAlias{ get; set; }

        /// <summary>
        /// <p>预付费资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>是否自动终止</p>
        /// </summary>
        [JsonProperty("AutoStopping")]
        public bool? AutoStopping{ get; set; }

        /// <summary>
        /// <p>自动停止时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutomaticStopTime")]
        public ulong? AutomaticStopTime{ get; set; }

        /// <summary>
        /// <p>存储的类型。取值包含：<br>    FREE:        预付费的免费存储<br>    CLOUD_PREMIUM： 高性能云硬盘<br>    CLOUD_SSD： SSD云硬盘<br>    CFS:     CFS存储，包含NFS和turbo</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeSourceType")]
        public string VolumeSourceType{ get; set; }

        /// <summary>
        /// <p>CFS存储的配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeSourceCFS")]
        public CFSConfig VolumeSourceCFS{ get; set; }

        /// <summary>
        /// <p>notebook 信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>notebook用户类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserTypes")]
        public string[] UserTypes{ get; set; }

        /// <summary>
        /// <p>SSH配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSHConfig")]
        public SSHConfig SSHConfig{ get; set; }

        /// <summary>
        /// <p>GooseFS存储配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeSourceGooseFS")]
        public GooseFS VolumeSourceGooseFS{ get; set; }

        /// <summary>
        /// <p>子用户ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// <p>子用户名称</p>
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }

        /// <summary>
        /// <p>AppId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>容器服务暴露端口配置</p>
        /// </summary>
        [JsonProperty("ExposePortConfig")]
        public ExposePortConfig ExposePortConfig{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>操作者信息</p>
        /// </summary>
        [JsonProperty("LatestOperatorInfo")]
        public OperatorInfo LatestOperatorInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "ResourceConf.", this.ResourceConf);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamArraySimple(map, prefix + "BillingInfos.", this.BillingInfos);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RuntimeInSeconds", this.RuntimeInSeconds);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "InstanceTypeAlias", this.InstanceTypeAlias);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "AutoStopping", this.AutoStopping);
            this.SetParamSimple(map, prefix + "AutomaticStopTime", this.AutomaticStopTime);
            this.SetParamSimple(map, prefix + "VolumeSourceType", this.VolumeSourceType);
            this.SetParamObj(map, prefix + "VolumeSourceCFS.", this.VolumeSourceCFS);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArraySimple(map, prefix + "UserTypes.", this.UserTypes);
            this.SetParamObj(map, prefix + "SSHConfig.", this.SSHConfig);
            this.SetParamObj(map, prefix + "VolumeSourceGooseFS.", this.VolumeSourceGooseFS);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamObj(map, prefix + "ExposePortConfig.", this.ExposePortConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "LatestOperatorInfo.", this.LatestOperatorInfo);
        }
    }
}

