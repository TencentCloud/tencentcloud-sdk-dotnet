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

    public class ModifyDatasourceRequest : AbstractModel
    {
        
        /// <summary>
        /// HOST
        /// </summary>
        [JsonProperty("DbHost")]
        public string DbHost{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("DbPort")]
        public ulong? DbPort{ get; set; }

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
        /// 数据源id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// catalog值
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

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
        /// 扩展参数
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// 腾讯云私有网络统一标识
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 私有网络ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 私有网络端口
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// 腾讯云私有网络标识
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 开启vpc	
        /// </summary>
        [JsonProperty("UseVPC")]
        public bool? UseVPC{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbHost", this.DbHost);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "DbPwd", this.DbPwd);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "DataOrigin", this.DataOrigin);
            this.SetParamSimple(map, prefix + "DataOriginProjectId", this.DataOriginProjectId);
            this.SetParamSimple(map, prefix + "DataOriginDatasourceId", this.DataOriginDatasourceId);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "UseVPC", this.UseVPC);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

