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

    public class CreateNotebookRequest : AbstractModel
    {
        
        /// <summary>
        /// 名称。不超过60个字符，仅支持中英文、数字、下划线"_"、短横"-"，只能以中英文、数字开头
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 计算资源付费模式 ，可选值为：
        /// PREPAID：预付费，即包年包月
        /// POSTPAID_BY_HOUR：按小时后付费
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 计算资源配置
        /// </summary>
        [JsonProperty("ResourceConf")]
        public ResourceConf ResourceConf{ get; set; }

        /// <summary>
        /// 是否上报日志
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 是否ROOT权限
        /// </summary>
        [JsonProperty("RootAccess")]
        public bool? RootAccess{ get; set; }

        /// <summary>
        /// 是否自动停止
        /// </summary>
        [JsonProperty("AutoStopping")]
        public bool? AutoStopping{ get; set; }

        /// <summary>
        /// 是否访问公网
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public bool? DirectInternetAccess{ get; set; }

        /// <summary>
        /// 资源组ID(for预付费)
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// Vpc-Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 存储的类型。取值包含： 
        /// FREE：预付费的免费存储
        /// CLOUD_PREMIUM：高性能云硬盘
        /// CLOUD_SSD：SSD云硬盘
        /// CFS：CFS存储
        /// CFS_TURBO：CFS Turbo存储
        /// GooseFSx：GooseFSx存储
        /// </summary>
        [JsonProperty("VolumeSourceType")]
        public string VolumeSourceType{ get; set; }

        /// <summary>
        /// 云硬盘存储卷大小，单位GB
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// CFS存储的配置
        /// </summary>
        [JsonProperty("VolumeSourceCFS")]
        public CFSConfig VolumeSourceCFS{ get; set; }

        /// <summary>
        /// 日志配置
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// 生命周期脚本的ID
        /// </summary>
        [JsonProperty("LifecycleScriptId")]
        public string LifecycleScriptId{ get; set; }

        /// <summary>
        /// 默认GIT存储库的ID
        /// </summary>
        [JsonProperty("DefaultCodeRepoId")]
        public string DefaultCodeRepoId{ get; set; }

        /// <summary>
        /// 其他GIT存储库的ID，最多3个
        /// </summary>
        [JsonProperty("AdditionalCodeRepoIds")]
        public string[] AdditionalCodeRepoIds{ get; set; }

        /// <summary>
        /// 自动停止时间，单位小时
        /// </summary>
        [JsonProperty("AutomaticStopTime")]
        public ulong? AutomaticStopTime{ get; set; }

        /// <summary>
        /// 标签配置
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 数据配置，只支持WEDATA_HDFS存储类型
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// 镜像信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 镜像类型，包括SYSTEM、TCR、CCR
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// SSH配置信息
        /// </summary>
        [JsonProperty("SSHConfig")]
        public SSHConfig SSHConfig{ get; set; }

        /// <summary>
        /// GooseFS存储配置
        /// </summary>
        [JsonProperty("VolumeSourceGooseFS")]
        public GooseFS VolumeSourceGooseFS{ get; set; }


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
        }
    }
}

