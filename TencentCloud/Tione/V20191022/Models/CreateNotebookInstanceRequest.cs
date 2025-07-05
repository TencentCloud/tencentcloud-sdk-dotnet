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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNotebookInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称，不能超过63个字符
        /// 规则：“^\[a-zA-Z0-9\](-\*\[a-zA-Z0-9\])\*$”
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// Notebook算力类型
        /// 参考https://cloud.tencent.com/document/product/851/41239
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 数据卷大小(GB)
        /// 用户持久化Notebook实例的数据
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// 外网访问权限，可取值Enabled/Disabled
        /// 开启后，Notebook实例可以具有访问外网80，443端口的权限
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public string DirectInternetAccess{ get; set; }

        /// <summary>
        /// Root用户权限，可取值Enabled/Disabled
        /// 开启后，Notebook实例可以切换至root用户执行命令
        /// </summary>
        [JsonProperty("RootAccess")]
        public string RootAccess{ get; set; }

        /// <summary>
        /// 子网ID
        /// 如果需要Notebook实例访问VPC内的资源，则需要选择对应的子网
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 生命周期脚本名称
        /// 必须是已存在的生命周期脚本，具体参考https://cloud.tencent.com/document/product/851/43140
        /// </summary>
        [JsonProperty("LifecycleScriptsName")]
        public string LifecycleScriptsName{ get; set; }

        /// <summary>
        /// 默认存储库名称
        /// 可以是已创建的存储库名称或者已https://开头的公共git库
        /// 参考https://cloud.tencent.com/document/product/851/43139
        /// </summary>
        [JsonProperty("DefaultCodeRepository")]
        public string DefaultCodeRepository{ get; set; }

        /// <summary>
        /// 其他存储库列表
        /// 每个元素可以是已创建的存储库名称或者已https://开头的公共git库
        /// 参考https://cloud.tencent.com/document/product/851/43139
        /// </summary>
        [JsonProperty("AdditionalCodeRepositories")]
        public string[] AdditionalCodeRepositories{ get; set; }

        /// <summary>
        /// 已弃用，请使用ClsConfig配置。
        /// 是否开启CLS日志服务，可取值Enabled/Disabled，默认为Disabled
        /// 开启后，Notebook运行的日志会收集到CLS中，CLS会产生费用，请根据需要选择
        /// </summary>
        [JsonProperty("ClsAccess")]
        public string ClsAccess{ get; set; }

        /// <summary>
        /// 自动停止配置
        /// 选择定时停止Notebook实例
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition{ get; set; }

        /// <summary>
        /// 自动停止，可取值Enabled/Disabled
        /// 取值为Disabled的时候StoppingCondition将被忽略
        /// 取值为Enabled的时候读取StoppingCondition作为自动停止的配置
        /// </summary>
        [JsonProperty("AutoStopping")]
        public string AutoStopping{ get; set; }

        /// <summary>
        /// 接入日志的配置，默认接入免费日志
        /// </summary>
        [JsonProperty("ClsConfig")]
        public ClsConfig ClsConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookInstanceName", this.NotebookInstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamSimple(map, prefix + "DirectInternetAccess", this.DirectInternetAccess);
            this.SetParamSimple(map, prefix + "RootAccess", this.RootAccess);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LifecycleScriptsName", this.LifecycleScriptsName);
            this.SetParamSimple(map, prefix + "DefaultCodeRepository", this.DefaultCodeRepository);
            this.SetParamArraySimple(map, prefix + "AdditionalCodeRepositories.", this.AdditionalCodeRepositories);
            this.SetParamSimple(map, prefix + "ClsAccess", this.ClsAccess);
            this.SetParamObj(map, prefix + "StoppingCondition.", this.StoppingCondition);
            this.SetParamSimple(map, prefix + "AutoStopping", this.AutoStopping);
            this.SetParamObj(map, prefix + "ClsConfig.", this.ClsConfig);
        }
    }
}

