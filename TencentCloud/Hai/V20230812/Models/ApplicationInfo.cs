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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 应用的环境配置
        /// </summary>
        [JsonProperty("ConfigEnvironment")]
        public string ConfigEnvironment{ get; set; }

        /// <summary>
        /// 系统盘大小下限
        /// </summary>
        [JsonProperty("MinSystemDiskSize")]
        public long? MinSystemDiskSize{ get; set; }

        /// <summary>
        /// 应用类型，目前该项取值可以为PRIVATE_APPLICATION或者PUBLIC_APPLICATION
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 应用状态：CREATING-创建中；ONLINE -正常在线；DELETING -删除中；ARREARS - 欠费隔离
        /// 示例值：ONLINE
        /// </summary>
        [JsonProperty("ApplicationState")]
        public string ApplicationState{ get; set; }

        /// <summary>
        /// 应用创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 应用大小
        /// </summary>
        [JsonProperty("ApplicationSize")]
        public long? ApplicationSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConfigEnvironment", this.ConfigEnvironment);
            this.SetParamSimple(map, prefix + "MinSystemDiskSize", this.MinSystemDiskSize);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "ApplicationState", this.ApplicationState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ApplicationSize", this.ApplicationSize);
        }
    }
}

