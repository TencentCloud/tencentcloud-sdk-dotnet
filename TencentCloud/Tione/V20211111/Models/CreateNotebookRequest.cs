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

    public class CreateNotebookRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>名称。不超过60个字符，仅支持中英文、数字、下划线&quot;_&quot;、短横&quot;-&quot;，只能以中英文、数字开头</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>计算资源付费模式 ，可选值为：<br>PREPAID：预付费，即包年包月<br>POSTPAID_BY_HOUR：按小时后付费</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>计算资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConf")]
        public ResourceConf ResourceConf{ get; set; }

        /// <summary>
        /// <p>是否上报日志</p>
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// <p>是否ROOT权限</p>
        /// </summary>
        [JsonProperty("RootAccess")]
        public bool? RootAccess{ get; set; }

        /// <summary>
        /// <p>是否自动停止</p>
        /// </summary>
        [JsonProperty("AutoStopping")]
        public bool? AutoStopping{ get; set; }

        /// <summary>
        /// <p>是否访问公网</p>
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public bool? DirectInternetAccess{ get; set; }

        /// <summary>
        /// <p>资源组ID(for预付费)</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>Vpc-Id</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网Id</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>存储的类型。取值包含：<br>FREE：预付费的免费存储<br>CLOUD_PREMIUM：高性能云硬盘<br>CLOUD_SSD：SSD云硬盘<br>CFS：CFS存储<br>CFS_TURBO：CFS Turbo存储<br>GooseFSx：GooseFSx存储</p>
        /// </summary>
        [JsonProperty("VolumeSourceType")]
        public string VolumeSourceType{ get; set; }

        /// <summary>
        /// <p>云硬盘存储卷大小，单位GB</p>
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// <p>CFS存储的配置</p>
        /// </summary>
        [JsonProperty("VolumeSourceCFS")]
        public CFSConfig VolumeSourceCFS{ get; set; }

        /// <summary>
        /// <p>日志配置</p>
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// <p>生命周期脚本的ID</p>
        /// </summary>
        [JsonProperty("LifecycleScriptId")]
        public string LifecycleScriptId{ get; set; }

        /// <summary>
        /// <p>默认GIT存储库的ID</p>
        /// </summary>
        [JsonProperty("DefaultCodeRepoId")]
        public string DefaultCodeRepoId{ get; set; }

        /// <summary>
        /// <p>其他GIT存储库的ID，最多3个</p>
        /// </summary>
        [JsonProperty("AdditionalCodeRepoIds")]
        public string[] AdditionalCodeRepoIds{ get; set; }

        /// <summary>
        /// <p>自动停止时间，单位小时</p>
        /// </summary>
        [JsonProperty("AutomaticStopTime")]
        public ulong? AutomaticStopTime{ get; set; }

        /// <summary>
        /// <p>标签配置</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>数据存储挂载配置</p>
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// <p>镜像信息</p>
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// <p>镜像类型，包括SYSTEM、TCR、CCR</p>
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// <p>SSH配置信息</p>
        /// </summary>
        [JsonProperty("SSHConfig")]
        public SSHConfig SSHConfig{ get; set; }

        /// <summary>
        /// <p>GooseFS存储配置</p>
        /// </summary>
        [JsonProperty("VolumeSourceGooseFS")]
        public GooseFS VolumeSourceGooseFS{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "ResourceConf.", this.ResourceConf);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "RootAccess", this.RootAccess);
            this.SetParamSimple(map, prefix + "AutoStopping", this.AutoStopping);
            this.SetParamSimple(map, prefix + "DirectInternetAccess", this.DirectInternetAccess);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VolumeSourceType", this.VolumeSourceType);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamObj(map, prefix + "VolumeSourceCFS.", this.VolumeSourceCFS);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "LifecycleScriptId", this.LifecycleScriptId);
            this.SetParamSimple(map, prefix + "DefaultCodeRepoId", this.DefaultCodeRepoId);
            this.SetParamArraySimple(map, prefix + "AdditionalCodeRepoIds.", this.AdditionalCodeRepoIds);
            this.SetParamSimple(map, prefix + "AutomaticStopTime", this.AutomaticStopTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamObj(map, prefix + "SSHConfig.", this.SSHConfig);
            this.SetParamObj(map, prefix + "VolumeSourceGooseFS.", this.VolumeSourceGooseFS);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

