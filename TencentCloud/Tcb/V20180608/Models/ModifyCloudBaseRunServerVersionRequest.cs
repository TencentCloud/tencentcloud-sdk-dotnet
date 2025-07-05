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

    public class ModifyCloudBaseRunServerVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 最小副本数
        /// </summary>
        [JsonProperty("MinNum")]
        public string MinNum{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxNum")]
        public string MaxNum{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public string ContainerPort{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 日志采集路径
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// 是否重设备注
        /// </summary>
        [JsonProperty("IsResetRemark")]
        public bool? IsResetRemark{ get; set; }

        /// <summary>
        /// 修改基础信息
        /// </summary>
        [JsonProperty("BasicModify")]
        public bool? BasicModify{ get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CustomLogs", this.CustomLogs);
            this.SetParamSimple(map, prefix + "IsResetRemark", this.IsResetRemark);
            this.SetParamSimple(map, prefix + "BasicModify", this.BasicModify);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
        }
    }
}

