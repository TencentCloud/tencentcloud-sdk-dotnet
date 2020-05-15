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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNotebookInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// Notebook算力类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 数据卷大小(GB)
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// 外网访问权限，可取值Enabled/Disabled
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public string DirectInternetAccess{ get; set; }

        /// <summary>
        /// Root用户权限，可取值Enabled/Disabled
        /// </summary>
        [JsonProperty("RootAccess")]
        public string RootAccess{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 生命周期脚本名称
        /// </summary>
        [JsonProperty("LifecycleScriptsName")]
        public string LifecycleScriptsName{ get; set; }

        /// <summary>
        /// 默认存储库名称
        /// 可以是已创建的存储库名称或者已https://开头的公共git库
        /// </summary>
        [JsonProperty("DefaultCodeRepository")]
        public string DefaultCodeRepository{ get; set; }

        /// <summary>
        /// 其他存储库列表
        /// 每个元素可以是已创建的存储库名称或者已https://开头的公共git库
        /// </summary>
        [JsonProperty("AdditionalCodeRepositories")]
        public string[] AdditionalCodeRepositories{ get; set; }

        /// <summary>
        /// 是否开启CLS日志服务，可取值Enabled/Disabled，默认为Disabled
        /// </summary>
        [JsonProperty("ClsAccess")]
        public string ClsAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

