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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateJobInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据迁移任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 数据迁移任务名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 迁移任务配置选项
        /// </summary>
        [JsonProperty("MigrateOption")]
        public MigrateOption MigrateOption{ get; set; }

        /// <summary>
        /// 源实例数据库类型:mysql，redis，mongodb，postgresql，mariadb，percona
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 源实例接入类型，值包括：extranet(外网),cvm(cvm自建实例),dcg(专线接入的实例),vpncloud(云vpn接入的实例),cdb(腾讯云数据库实例),ccn(云联网实例)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源实例信息，具体内容跟迁移任务类型相关
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SrcInfo SrcInfo{ get; set; }

        /// <summary>
        /// 目标实例数据库类型:mysql，redis，mongodb，postgresql，mariadb，percona
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例接入类型，目前支持：cdb(腾讯云数据库实例)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 目标实例信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public DstInfo DstInfo{ get; set; }

        /// <summary>
        /// 需要迁移的源数据库表信息，如果需要迁移的是整个实例，该字段为[]
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }

        /// <summary>
        /// 任务创建(提交)时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务开始执行时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务执行结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务状态,取值为：1-创建中(Creating),3-校验中(Checking)4-校验通过(CheckPass),5-校验不通过（CheckNotPass）,7-任务运行(Running),8-准备完成（ReadyComplete）,9-任务成功（Success）,10-任务失败（Failed）,11-撤销中（Stopping）,12-完成中（Completing）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务详情
        /// </summary>
        [JsonProperty("Detail")]
        public MigrateDetailInfo Detail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "MigrateOption.", this.MigrateOption);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
        }
    }
}

