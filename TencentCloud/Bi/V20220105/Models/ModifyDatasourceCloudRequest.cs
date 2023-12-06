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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDatasourceCloudRequest : AbstractModel
    {
        
        /// <summary>
        /// 后端提供字典：域类型，1、腾讯云，2、本地
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 驱动
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 数据库编码
        /// </summary>
        [JsonProperty("Charset")]
        public string Charset{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("DbPwd")]
        public string DbPwd{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 数据库别名
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 住键
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 公有云内网ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 公有云内网端口
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// vpc标识
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 统一vpc标识
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 区域标识（gz,bj)
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 数据源产品名
        /// </summary>
        [JsonProperty("ProdDbName")]
        public string ProdDbName{ get; set; }

        /// <summary>
        /// 第三方数据源标识
        /// </summary>
        [JsonProperty("DataOrigin")]
        public string DataOrigin{ get; set; }

        /// <summary>
        /// 第三方项目id
        /// </summary>
        [JsonProperty("DataOriginProjectId")]
        public string DataOriginProjectId{ get; set; }

        /// <summary>
        /// 第三方数据源id
        /// </summary>
        [JsonProperty("DataOriginDatasourceId")]
        public string DataOriginDatasourceId{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "DbPwd", this.DbPwd);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProdDbName", this.ProdDbName);
            this.SetParamSimple(map, prefix + "DataOrigin", this.DataOrigin);
            this.SetParamSimple(map, prefix + "DataOriginProjectId", this.DataOriginProjectId);
            this.SetParamSimple(map, prefix + "DataOriginDatasourceId", this.DataOriginDatasourceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
        }
    }
}

