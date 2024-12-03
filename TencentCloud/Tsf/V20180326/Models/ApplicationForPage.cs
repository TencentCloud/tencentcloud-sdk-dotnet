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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationForPage : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationDesc")]
        public string ApplicationDesc{ get; set; }

        /// <summary>
        /// 应用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 微服务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// 编程语言
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgLang")]
        public string ProgLang{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 应用资源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationResourceType")]
        public string ApplicationResourceType{ get; set; }

        /// <summary>
        /// 应用runtime类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationRuntimeType")]
        public string ApplicationRuntimeType{ get; set; }

        /// <summary>
        /// Apigateway的serviceId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApigatewayServiceId")]
        public string ApigatewayServiceId{ get; set; }

        /// <summary>
        /// 应用备注名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationRemarkName")]
        public string ApplicationRemarkName{ get; set; }

        /// <summary>
        /// 服务配置信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceConfigList")]
        public ServiceConfig[] ServiceConfigList{ get; set; }

        /// <summary>
        /// IgnoreCreateImageRepository
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreCreateImageRepository")]
        public bool? IgnoreCreateImageRepository{ get; set; }

        /// <summary>
        /// Apm业务系统id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApmInstanceId")]
        public string ApmInstanceId{ get; set; }

        /// <summary>
        /// Apm业务系统Name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApmInstanceName")]
        public string ApmInstanceName{ get; set; }

        /// <summary>
        /// 同步删除镜像仓库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncDeleteImageRepository")]
        public bool? SyncDeleteImageRepository{ get; set; }

        /// <summary>
        /// 应用微服务子类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceSubType")]
        public string MicroserviceSubType{ get; set; }

        /// <summary>
        /// 应用编程语言类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramLanguage")]
        public string ProgramLanguage{ get; set; }

        /// <summary>
        /// 开发框架类型[SpringCloud，Dubbo，Go-GRPC，Other]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameworkType")]
        public string FrameworkType{ get; set; }

        /// <summary>
        /// 注册配置治理信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceGovernanceConfig")]
        public ServiceGovernanceConfig ServiceGovernanceConfig{ get; set; }

        /// <summary>
        /// 微服务类型列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceTypeList")]
        public string[] MicroserviceTypeList{ get; set; }

        /// <summary>
        /// 是否同时创建镜像仓库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateSameNameImageRepository")]
        public bool? CreateSameNameImageRepository{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationDesc", this.ApplicationDesc);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "ProgLang", this.ProgLang);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ApplicationResourceType", this.ApplicationResourceType);
            this.SetParamSimple(map, prefix + "ApplicationRuntimeType", this.ApplicationRuntimeType);
            this.SetParamSimple(map, prefix + "ApigatewayServiceId", this.ApigatewayServiceId);
            this.SetParamSimple(map, prefix + "ApplicationRemarkName", this.ApplicationRemarkName);
            this.SetParamArrayObj(map, prefix + "ServiceConfigList.", this.ServiceConfigList);
            this.SetParamSimple(map, prefix + "IgnoreCreateImageRepository", this.IgnoreCreateImageRepository);
            this.SetParamSimple(map, prefix + "ApmInstanceId", this.ApmInstanceId);
            this.SetParamSimple(map, prefix + "ApmInstanceName", this.ApmInstanceName);
            this.SetParamSimple(map, prefix + "SyncDeleteImageRepository", this.SyncDeleteImageRepository);
            this.SetParamSimple(map, prefix + "MicroserviceSubType", this.MicroserviceSubType);
            this.SetParamSimple(map, prefix + "ProgramLanguage", this.ProgramLanguage);
            this.SetParamSimple(map, prefix + "FrameworkType", this.FrameworkType);
            this.SetParamObj(map, prefix + "ServiceGovernanceConfig.", this.ServiceGovernanceConfig);
            this.SetParamArraySimple(map, prefix + "MicroserviceTypeList.", this.MicroserviceTypeList);
            this.SetParamSimple(map, prefix + "CreateSameNameImageRepository", this.CreateSameNameImageRepository);
        }
    }
}

