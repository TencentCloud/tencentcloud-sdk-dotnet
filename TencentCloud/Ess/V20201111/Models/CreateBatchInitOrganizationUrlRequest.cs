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

    public class CreateBatchInitOrganizationUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。<br>注: <code>在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</code></p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>初始化操作类型<ul><li>CREATE_SEAL : 创建印章</li><li>AUTH_JOIN_ORGANIZATION_GROUP : 加入集团企业</li><li>OPEN_AUTO_SIGN :开通企业“授权签”</li><li>PARTNER_AUTO_SIGN_AUTH :合作方企业授权“授权签”</li><li>CHANGE_SUB_ORGANIZATION_ADMIN_AUTH :变更子企业超管授权(<strong>授权后，主企业可变更子企业超管，此功能需联系客户经理开通白名单使用</strong>)</li></ul></p>
        /// </summary>
        [JsonProperty("OperateTypes")]
        public string[] OperateTypes{ get; set; }

        /// <summary>
        /// <p>批量操作的企业Id列表，最大支持50个</p>
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string[] OrganizationIds{ get; set; }

        /// <summary>
        /// <p>代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>被授权的合作方企业在电子签的企业电子签账号，当操作类型包含 PARTNER_AUTO_SIGN_AUTH （合作方企业授权“授权签”）时必传。企业电子签账号可在<a href="https://qian.tencent.com/console/company-settings/company-center">电子签的网页端</a> ，于企业设置-企业信息菜单栏下复制获取。<img src="https://qcloudimg.tencent-cloud.cn/raw/4e6b30ee92f00671f7f1c5bd127c27db.png" alt="企业电子签账号"></p>
        /// </summary>
        [JsonProperty("AuthorizedOrganizationId")]
        public string AuthorizedOrganizationId{ get; set; }

        /// <summary>
        /// <p>初始化操作类型里含有CHANGE_SUB_ORGANIZATION_ADMIN_AUTH（变更子企业超管授权）操作类型时，授权协议中主企业的签署方是否使用“授权签”（需操作人有“授权签”授权）</p>
        /// </summary>
        [JsonProperty("ChangeAdminAuthAutoSign")]
        public bool? ChangeAdminAuthAutoSign{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "OperateTypes.", this.OperateTypes);
            this.SetParamArraySimple(map, prefix + "OrganizationIds.", this.OrganizationIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationId", this.AuthorizedOrganizationId);
            this.SetParamSimple(map, prefix + "ChangeAdminAuthAutoSign", this.ChangeAdminAuthAutoSign);
        }
    }
}

