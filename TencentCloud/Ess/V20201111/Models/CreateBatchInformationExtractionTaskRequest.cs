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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBatchInformationExtractionTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行合同智能提取的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同智能提取的PDF文件资源编号列表，通过[UploadFiles](https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles)接口获取PDF文件资源编号。
        /// 
        ///  注:  `目前，此接口仅支持5个文件发起。每个文件限制在10M以下`
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 用户配置的合同智能提取字段模板ID，会基于此模板批量创建合同智能提取任务，为32位字符串。
        /// [点击查看模板Id在控制台上的位置](https://qcloudimg.tencent-cloud.cn/raw/99008608577532423ea437c7fdbedca1.png)
        /// 
        /// 注:  `此配置优先级最高，设置了模板ID后Fields配置就会无效`
        /// </summary>
        [JsonProperty("FieldTemplateId")]
        public string FieldTemplateId{ get; set; }

        /// <summary>
        /// 用于合同智能提取的字段信息。
        /// 
        /// 注意：`字段模板优先级最高，如果设置了FieldTemplateId值，此配置就无效`
        /// </summary>
        [JsonProperty("Fields")]
        public ExtractionField[] Fields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FieldTemplateId", this.FieldTemplateId);
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
        }
    }
}

