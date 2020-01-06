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

namespace TencentCloud.Msp.V20180319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，取值database（数据库迁移）、file（文件迁移）、host（主机迁移）
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 服务提供商名称
        /// </summary>
        [JsonProperty("ServiceSupplier")]
        public string ServiceSupplier{ get; set; }

        /// <summary>
        /// 迁移任务源信息
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SrcInfo SrcInfo{ get; set; }

        /// <summary>
        /// 迁移任务目的信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public DstInfo DstInfo{ get; set; }

        /// <summary>
        /// 迁移任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 迁移任务更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 迁移类别，如数据库迁移中mysql:mysql代表从mysql迁移到mysql，文件迁移中oss:cos代表从阿里云oss迁移到腾讯云cos
        /// </summary>
        [JsonProperty("MigrateClass")]
        public string MigrateClass{ get; set; }

        /// <summary>
        /// 源实例接入类型，数据库迁移时填写值为：extranet(外网),cvm(cvm自建实例),dcg(专线接入的实例),vpncloud(云vpn接入的实例),vpnselfbuild(自建vpn接入的实例)，cdb(云上cdb实例)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源实例数据库类型，数据库迁移时填写，取值为mysql,redis,percona,mongodb,postgresql,sqlserver,mariadb 之一
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例接入类型，数据库迁移时填写值为：extranet(外网),cvm(cvm自建实例),dcg(专线接入的实例),vpncloud(云vpn接入的实例),vpnselfbuild(自建vpn接入的实例)，cdb(云上cdb实例)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 目标实例数据库类型,数据库迁移时填写，取值为mysql,redis,percona,mongodb,postgresql,sqlserver,mariadb 之一
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ServiceSupplier", this.ServiceSupplier);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "MigrateClass", this.MigrateClass);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
        }
    }
}

