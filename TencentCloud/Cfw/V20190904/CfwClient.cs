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

namespace TencentCloud.Cfw.V20190904
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfw.V20190904.Models;

   public class CfwClient : AbstractClient{

       private const string endpoint = "cfw.tencentcloudapi.com";
       private const string version = "2019-09-04";
       private const string sdkVersion = "SDK_NET_3.0.1034";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public Task<AddAcRuleResponse> AddAcRule(AddAcRuleRequest req)
        {
            return InternalRequestAsync<AddAcRuleResponse>(req, "AddAcRule");
        }

        /// <summary>
        /// 添加互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public AddAcRuleResponse AddAcRuleSync(AddAcRuleRequest req)
        {
            return InternalRequestAsync<AddAcRuleResponse>(req, "AddAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="AddAclRuleRequest"/></param>
        /// <returns><see cref="AddAclRuleResponse"/></returns>
        public Task<AddAclRuleResponse> AddAclRule(AddAclRuleRequest req)
        {
            return InternalRequestAsync<AddAclRuleResponse>(req, "AddAclRule");
        }

        /// <summary>
        /// 添加互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="AddAclRuleRequest"/></param>
        /// <returns><see cref="AddAclRuleResponse"/></returns>
        public AddAclRuleResponse AddAclRuleSync(AddAclRuleRequest req)
        {
            return InternalRequestAsync<AddAclRuleResponse>(req, "AddAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public Task<AddEnterpriseSecurityGroupRulesResponse> AddEnterpriseSecurityGroupRules(AddEnterpriseSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<AddEnterpriseSecurityGroupRulesResponse>(req, "AddEnterpriseSecurityGroupRules");
        }

        /// <summary>
        /// 创建新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public AddEnterpriseSecurityGroupRulesResponse AddEnterpriseSecurityGroupRulesSync(AddEnterpriseSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<AddEnterpriseSecurityGroupRulesResponse>(req, "AddEnterpriseSecurityGroupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加nat访问控制规则(地域必填)
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public Task<AddNatAcRuleResponse> AddNatAcRule(AddNatAcRuleRequest req)
        {
            return InternalRequestAsync<AddNatAcRuleResponse>(req, "AddNatAcRule");
        }

        /// <summary>
        /// 添加nat访问控制规则(地域必填)
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public AddNatAcRuleResponse AddNatAcRuleSync(AddNatAcRuleRequest req)
        {
            return InternalRequestAsync<AddNatAcRuleResponse>(req, "AddNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加VPC内网间规则
        /// </summary>
        /// <param name="req"><see cref="AddVpcAcRuleRequest"/></param>
        /// <returns><see cref="AddVpcAcRuleResponse"/></returns>
        public Task<AddVpcAcRuleResponse> AddVpcAcRule(AddVpcAcRuleRequest req)
        {
            return InternalRequestAsync<AddVpcAcRuleResponse>(req, "AddVpcAcRule");
        }

        /// <summary>
        /// 添加VPC内网间规则
        /// </summary>
        /// <param name="req"><see cref="AddVpcAcRuleRequest"/></param>
        /// <returns><see cref="AddVpcAcRuleResponse"/></returns>
        public AddVpcAcRuleResponse AddVpcAcRuleSync(AddVpcAcRuleRequest req)
        {
            return InternalRequestAsync<AddVpcAcRuleResponse>(req, "AddVpcAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
            return InternalRequestAsync<CreateAcRulesResponse>(req, "CreateAcRules");
        }

        /// <summary>
        /// 创建访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
            return InternalRequestAsync<CreateAcRulesResponse>(req, "CreateAcRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建地址模板规则
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate");
        }

        /// <summary>
        /// 创建地址模板规则
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户告警中心-封隔离处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterIsolateRequest"/></param>
        /// <returns><see cref="CreateAlertCenterIsolateResponse"/></returns>
        public Task<CreateAlertCenterIsolateResponse> CreateAlertCenterIsolate(CreateAlertCenterIsolateRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterIsolateResponse>(req, "CreateAlertCenterIsolate");
        }

        /// <summary>
        /// 用户告警中心-封隔离处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterIsolateRequest"/></param>
        /// <returns><see cref="CreateAlertCenterIsolateResponse"/></returns>
        public CreateAlertCenterIsolateResponse CreateAlertCenterIsolateSync(CreateAlertCenterIsolateRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterIsolateResponse>(req, "CreateAlertCenterIsolate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户告警中心-忽略处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterOmitRequest"/></param>
        /// <returns><see cref="CreateAlertCenterOmitResponse"/></returns>
        public Task<CreateAlertCenterOmitResponse> CreateAlertCenterOmit(CreateAlertCenterOmitRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterOmitResponse>(req, "CreateAlertCenterOmit");
        }

        /// <summary>
        /// 用户告警中心-忽略处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterOmitRequest"/></param>
        /// <returns><see cref="CreateAlertCenterOmitResponse"/></returns>
        public CreateAlertCenterOmitResponse CreateAlertCenterOmitSync(CreateAlertCenterOmitRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterOmitResponse>(req, "CreateAlertCenterOmit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户告警中心-封禁、放通处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterRuleRequest"/></param>
        /// <returns><see cref="CreateAlertCenterRuleResponse"/></returns>
        public Task<CreateAlertCenterRuleResponse> CreateAlertCenterRule(CreateAlertCenterRuleRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterRuleResponse>(req, "CreateAlertCenterRule");
        }

        /// <summary>
        /// 用户告警中心-封禁、放通处置按钮
        /// </summary>
        /// <param name="req"><see cref="CreateAlertCenterRuleRequest"/></param>
        /// <returns><see cref="CreateAlertCenterRuleResponse"/></returns>
        public CreateAlertCenterRuleResponse CreateAlertCenterRuleSync(CreateAlertCenterRuleRequest req)
        {
            return InternalRequestAsync<CreateAlertCenterRuleResponse>(req, "CreateAlertCenterRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="CreateBlockIgnoreRuleListRequest"/></param>
        /// <returns><see cref="CreateBlockIgnoreRuleListResponse"/></returns>
        public Task<CreateBlockIgnoreRuleListResponse> CreateBlockIgnoreRuleList(CreateBlockIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<CreateBlockIgnoreRuleListResponse>(req, "CreateBlockIgnoreRuleList");
        }

        /// <summary>
        /// 批量添加入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="CreateBlockIgnoreRuleListRequest"/></param>
        /// <returns><see cref="CreateBlockIgnoreRuleListResponse"/></returns>
        public CreateBlockIgnoreRuleListResponse CreateBlockIgnoreRuleListSync(CreateBlockIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<CreateBlockIgnoreRuleListResponse>(req, "CreateBlockIgnoreRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="CreateBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="CreateBlockIgnoreRuleNewResponse"/></returns>
        public Task<CreateBlockIgnoreRuleNewResponse> CreateBlockIgnoreRuleNew(CreateBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<CreateBlockIgnoreRuleNewResponse>(req, "CreateBlockIgnoreRuleNew");
        }

        /// <summary>
        /// 批量添加入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="CreateBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="CreateBlockIgnoreRuleNewResponse"/></returns>
        public CreateBlockIgnoreRuleNewResponse CreateBlockIgnoreRuleNewSync(CreateBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<CreateBlockIgnoreRuleNewResponse>(req, "CreateBlockIgnoreRuleNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建、选择vpc
        /// </summary>
        /// <param name="req"><see cref="CreateChooseVpcsRequest"/></param>
        /// <returns><see cref="CreateChooseVpcsResponse"/></returns>
        public Task<CreateChooseVpcsResponse> CreateChooseVpcs(CreateChooseVpcsRequest req)
        {
            return InternalRequestAsync<CreateChooseVpcsResponse>(req, "CreateChooseVpcs");
        }

        /// <summary>
        /// 创建、选择vpc
        /// </summary>
        /// <param name="req"><see cref="CreateChooseVpcsRequest"/></param>
        /// <returns><see cref="CreateChooseVpcsResponse"/></returns>
        public CreateChooseVpcsResponse CreateChooseVpcsSync(CreateChooseVpcsRequest req)
        {
            return InternalRequestAsync<CreateChooseVpcsResponse>(req, "CreateChooseVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建暴露数据库白名单规则
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseWhiteListRulesRequest"/></param>
        /// <returns><see cref="CreateDatabaseWhiteListRulesResponse"/></returns>
        public Task<CreateDatabaseWhiteListRulesResponse> CreateDatabaseWhiteListRules(CreateDatabaseWhiteListRulesRequest req)
        {
            return InternalRequestAsync<CreateDatabaseWhiteListRulesResponse>(req, "CreateDatabaseWhiteListRules");
        }

        /// <summary>
        /// 创建暴露数据库白名单规则
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseWhiteListRulesRequest"/></param>
        /// <returns><see cref="CreateDatabaseWhiteListRulesResponse"/></returns>
        public CreateDatabaseWhiteListRulesResponse CreateDatabaseWhiteListRulesSync(CreateDatabaseWhiteListRulesRequest req)
        {
            return InternalRequestAsync<CreateDatabaseWhiteListRulesResponse>(req, "CreateDatabaseWhiteListRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="CreateIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="CreateIdsWhiteRuleResponse"/></returns>
        public Task<CreateIdsWhiteRuleResponse> CreateIdsWhiteRule(CreateIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<CreateIdsWhiteRuleResponse>(req, "CreateIdsWhiteRule");
        }

        /// <summary>
        /// 创建入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="CreateIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="CreateIdsWhiteRuleResponse"/></returns>
        public CreateIdsWhiteRuleResponse CreateIdsWhiteRuleSync(CreateIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<CreateIdsWhiteRuleResponse>(req, "CreateIdsWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建NAT防火墙实例（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public Task<CreateNatFwInstanceResponse> CreateNatFwInstance(CreateNatFwInstanceRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceResponse>(req, "CreateNatFwInstance");
        }

        /// <summary>
        /// 创建NAT防火墙实例（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public CreateNatFwInstanceResponse CreateNatFwInstanceSync(CreateNatFwInstanceRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceResponse>(req, "CreateNatFwInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建防火墙实例和接入域名（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public Task<CreateNatFwInstanceWithDomainResponse> CreateNatFwInstanceWithDomain(CreateNatFwInstanceWithDomainRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceWithDomainResponse>(req, "CreateNatFwInstanceWithDomain");
        }

        /// <summary>
        /// 创建防火墙实例和接入域名（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public CreateNatFwInstanceWithDomainResponse CreateNatFwInstanceWithDomainSync(CreateNatFwInstanceWithDomainRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceWithDomainResponse>(req, "CreateNatFwInstanceWithDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public Task<CreateSecurityGroupRulesResponse> CreateSecurityGroupRules(CreateSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRulesResponse>(req, "CreateSecurityGroupRules");
        }

        /// <summary>
        /// 创建企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public CreateSecurityGroupRulesResponse CreateSecurityGroupRulesSync(CreateSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRulesResponse>(req, "CreateSecurityGroupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建VPC间防火墙(防火墙组)
        /// </summary>
        /// <param name="req"><see cref="CreateVpcFwGroupRequest"/></param>
        /// <returns><see cref="CreateVpcFwGroupResponse"/></returns>
        public Task<CreateVpcFwGroupResponse> CreateVpcFwGroup(CreateVpcFwGroupRequest req)
        {
            return InternalRequestAsync<CreateVpcFwGroupResponse>(req, "CreateVpcFwGroup");
        }

        /// <summary>
        /// 创建VPC间防火墙(防火墙组)
        /// </summary>
        /// <param name="req"><see cref="CreateVpcFwGroupRequest"/></param>
        /// <returns><see cref="CreateVpcFwGroupResponse"/></returns>
        public CreateVpcFwGroupResponse CreateVpcFwGroupSync(CreateVpcFwGroupRequest req)
        {
            return InternalRequestAsync<CreateVpcFwGroupResponse>(req, "CreateVpcFwGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
            return InternalRequestAsync<DeleteAcRuleResponse>(req, "DeleteAcRule");
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
            return InternalRequestAsync<DeleteAcRuleResponse>(req, "DeleteAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除地址模板规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate");
        }

        /// <summary>
        /// 删除地址模板规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllAccessControlRuleResponse>(req, "DeleteAllAccessControlRule");
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllAccessControlRuleResponse>(req, "DeleteAllAccessControlRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBlockIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DeleteBlockIgnoreRuleListResponse"/></returns>
        public Task<DeleteBlockIgnoreRuleListResponse> DeleteBlockIgnoreRuleList(DeleteBlockIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DeleteBlockIgnoreRuleListResponse>(req, "DeleteBlockIgnoreRuleList");
        }

        /// <summary>
        /// 批量删除入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBlockIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DeleteBlockIgnoreRuleListResponse"/></returns>
        public DeleteBlockIgnoreRuleListResponse DeleteBlockIgnoreRuleListSync(DeleteBlockIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DeleteBlockIgnoreRuleListResponse>(req, "DeleteBlockIgnoreRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除入侵防御封禁列表、放通列表规则（新）
        /// </summary>
        /// <param name="req"><see cref="DeleteBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="DeleteBlockIgnoreRuleNewResponse"/></returns>
        public Task<DeleteBlockIgnoreRuleNewResponse> DeleteBlockIgnoreRuleNew(DeleteBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<DeleteBlockIgnoreRuleNewResponse>(req, "DeleteBlockIgnoreRuleNew");
        }

        /// <summary>
        /// 批量删除入侵防御封禁列表、放通列表规则（新）
        /// </summary>
        /// <param name="req"><see cref="DeleteBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="DeleteBlockIgnoreRuleNewResponse"/></returns>
        public DeleteBlockIgnoreRuleNewResponse DeleteBlockIgnoreRuleNewSync(DeleteBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<DeleteBlockIgnoreRuleNewResponse>(req, "DeleteBlockIgnoreRuleNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteIdsWhiteRuleResponse"/></returns>
        public Task<DeleteIdsWhiteRuleResponse> DeleteIdsWhiteRule(DeleteIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteIdsWhiteRuleResponse>(req, "DeleteIdsWhiteRule");
        }

        /// <summary>
        /// 删除入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteIdsWhiteRuleResponse"/></returns>
        public DeleteIdsWhiteRuleResponse DeleteIdsWhiteRuleSync(DeleteIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteIdsWhiteRuleResponse>(req, "DeleteIdsWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNatFwInstanceRequest"/></param>
        /// <returns><see cref="DeleteNatFwInstanceResponse"/></returns>
        public Task<DeleteNatFwInstanceResponse> DeleteNatFwInstance(DeleteNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DeleteNatFwInstanceResponse>(req, "DeleteNatFwInstance");
        }

        /// <summary>
        /// 销毁防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNatFwInstanceRequest"/></param>
        /// <returns><see cref="DeleteNatFwInstanceResponse"/></returns>
        public DeleteNatFwInstanceResponse DeleteNatFwInstanceSync(DeleteNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DeleteNatFwInstanceResponse>(req, "DeleteNatFwInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteResourceGroup-资产中心资产组删除
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup");
        }

        /// <summary>
        /// DeleteResourceGroup-资产中心资产组删除
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule");
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除防火墙(组)，或者删除其中实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcFwGroupRequest"/></param>
        /// <returns><see cref="DeleteVpcFwGroupResponse"/></returns>
        public Task<DeleteVpcFwGroupResponse> DeleteVpcFwGroup(DeleteVpcFwGroupRequest req)
        {
            return InternalRequestAsync<DeleteVpcFwGroupResponse>(req, "DeleteVpcFwGroup");
        }

        /// <summary>
        /// 删除防火墙(组)，或者删除其中实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcFwGroupRequest"/></param>
        /// <returns><see cref="DeleteVpcFwGroupResponse"/></returns>
        public DeleteVpcFwGroupResponse DeleteVpcFwGroupSync(DeleteVpcFwGroupRequest req)
        {
            return InternalRequestAsync<DeleteVpcFwGroupResponse>(req, "DeleteVpcFwGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口废弃
        /// 
        /// 删除防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public Task<DeleteVpcInstanceResponse> DeleteVpcInstance(DeleteVpcInstanceRequest req)
        {
            return InternalRequestAsync<DeleteVpcInstanceResponse>(req, "DeleteVpcInstance");
        }

        /// <summary>
        /// 接口废弃
        /// 
        /// 删除防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public DeleteVpcInstanceResponse DeleteVpcInstanceSync(DeleteVpcInstanceRequest req)
        {
            return InternalRequestAsync<DeleteVpcInstanceResponse>(req, "DeleteVpcInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
            return InternalRequestAsync<DescribeAcListsResponse>(req, "DescribeAcLists");
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
            return InternalRequestAsync<DescribeAcListsResponse>(req, "DescribeAcLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询互联网边界访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public Task<DescribeAclRuleResponse> DescribeAclRule(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule");
        }

        /// <summary>
        /// 查询互联网边界访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public DescribeAclRuleResponse DescribeAclRuleSync(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询地址模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateListRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateListResponse"/></returns>
        public Task<DescribeAddressTemplateListResponse> DescribeAddressTemplateList(DescribeAddressTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateListResponse>(req, "DescribeAddressTemplateList");
        }

        /// <summary>
        /// 查询地址模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateListRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateListResponse"/></returns>
        public DescribeAddressTemplateListResponse DescribeAddressTemplateListSync(DescribeAddressTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateListResponse>(req, "DescribeAddressTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产同步状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncResponse"/></returns>
        public Task<DescribeAssetSyncResponse> DescribeAssetSync(DescribeAssetSyncRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncResponse>(req, "DescribeAssetSync");
        }

        /// <summary>
        /// 资产同步状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncResponse"/></returns>
        public DescribeAssetSyncResponse DescribeAssetSyncSync(DescribeAssetSyncRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncResponse>(req, "DescribeAssetSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public Task<DescribeAssociatedInstanceListResponse> DescribeAssociatedInstanceList(DescribeAssociatedInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAssociatedInstanceListResponse>(req, "DescribeAssociatedInstanceList");
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public DescribeAssociatedInstanceListResponse DescribeAssociatedInstanceListSync(DescribeAssociatedInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAssociatedInstanceListResponse>(req, "DescribeAssociatedInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public Task<DescribeBlockByIpTimesListResponse> DescribeBlockByIpTimesList(DescribeBlockByIpTimesListRequest req)
        {
            return InternalRequestAsync<DescribeBlockByIpTimesListResponse>(req, "DescribeBlockByIpTimesList");
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public DescribeBlockByIpTimesListResponse DescribeBlockByIpTimesListSync(DescribeBlockByIpTimesListRequest req)
        {
            return InternalRequestAsync<DescribeBlockByIpTimesListResponse>(req, "DescribeBlockByIpTimesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询入侵防御放通封禁列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public Task<DescribeBlockIgnoreListResponse> DescribeBlockIgnoreList(DescribeBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIgnoreListResponse>(req, "DescribeBlockIgnoreList");
        }

        /// <summary>
        /// 查询入侵防御放通封禁列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public DescribeBlockIgnoreListResponse DescribeBlockIgnoreListSync(DescribeBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIgnoreListResponse>(req, "DescribeBlockIgnoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public Task<DescribeBlockStaticListResponse> DescribeBlockStaticList(DescribeBlockStaticListRequest req)
        {
            return InternalRequestAsync<DescribeBlockStaticListResponse>(req, "DescribeBlockStaticList");
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public DescribeBlockStaticListResponse DescribeBlockStaticListSync(DescribeBlockStaticListRequest req)
        {
            return InternalRequestAsync<DescribeBlockStaticListResponse>(req, "DescribeBlockStaticList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public Task<DescribeCfwEipsResponse> DescribeCfwEips(DescribeCfwEipsRequest req)
        {
            return InternalRequestAsync<DescribeCfwEipsResponse>(req, "DescribeCfwEips");
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public DescribeCfwEipsResponse DescribeCfwEipsSync(DescribeCfwEipsRequest req)
        {
            return InternalRequestAsync<DescribeCfwEipsResponse>(req, "DescribeCfwEips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取入侵防御按钮列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public Task<DescribeDefenseSwitchResponse> DescribeDefenseSwitch(DescribeDefenseSwitchRequest req)
        {
            return InternalRequestAsync<DescribeDefenseSwitchResponse>(req, "DescribeDefenseSwitch");
        }

        /// <summary>
        /// 获取入侵防御按钮列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public DescribeDefenseSwitchResponse DescribeDefenseSwitchSync(DescribeDefenseSwitchRequest req)
        {
            return InternalRequestAsync<DescribeDefenseSwitchResponse>(req, "DescribeDefenseSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询新版安全组下发进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSGRuleProgressRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSGRuleProgressResponse"/></returns>
        public Task<DescribeEnterpriseSGRuleProgressResponse> DescribeEnterpriseSGRuleProgress(DescribeEnterpriseSGRuleProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSGRuleProgressResponse>(req, "DescribeEnterpriseSGRuleProgress");
        }

        /// <summary>
        /// 查询新版安全组下发进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSGRuleProgressRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSGRuleProgressResponse"/></returns>
        public DescribeEnterpriseSGRuleProgressResponse DescribeEnterpriseSGRuleProgressSync(DescribeEnterpriseSGRuleProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSGRuleProgressResponse>(req, "DescribeEnterpriseSGRuleProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<DescribeEnterpriseSecurityGroupRuleResponse> DescribeEnterpriseSecurityGroupRule(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSecurityGroupRuleResponse>(req, "DescribeEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// 查询新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public DescribeEnterpriseSecurityGroupRuleResponse DescribeEnterpriseSecurityGroupRuleSync(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSecurityGroupRuleResponse>(req, "DescribeEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 串行防火墙IP开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFwEdgeIpsRequest"/></param>
        /// <returns><see cref="DescribeFwEdgeIpsResponse"/></returns>
        public Task<DescribeFwEdgeIpsResponse> DescribeFwEdgeIps(DescribeFwEdgeIpsRequest req)
        {
            return InternalRequestAsync<DescribeFwEdgeIpsResponse>(req, "DescribeFwEdgeIps");
        }

        /// <summary>
        /// 串行防火墙IP开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFwEdgeIpsRequest"/></param>
        /// <returns><see cref="DescribeFwEdgeIpsResponse"/></returns>
        public DescribeFwEdgeIpsResponse DescribeFwEdgeIpsSync(DescribeFwEdgeIpsRequest req)
        {
            return InternalRequestAsync<DescribeFwEdgeIpsResponse>(req, "DescribeFwEdgeIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取租户所有VPC防火墙(组)及VPC防火墙实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFwGroupInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeFwGroupInstanceInfoResponse"/></returns>
        public Task<DescribeFwGroupInstanceInfoResponse> DescribeFwGroupInstanceInfo(DescribeFwGroupInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeFwGroupInstanceInfoResponse>(req, "DescribeFwGroupInstanceInfo");
        }

        /// <summary>
        /// 获取租户所有VPC防火墙(组)及VPC防火墙实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFwGroupInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeFwGroupInstanceInfoResponse"/></returns>
        public DescribeFwGroupInstanceInfoResponse DescribeFwGroupInstanceInfoSync(DescribeFwGroupInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeFwGroupInstanceInfoResponse>(req, "DescribeFwGroupInstanceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防火墙同步状态，一般在执行同步操作后查询
        /// </summary>
        /// <param name="req"><see cref="DescribeFwSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeFwSyncStatusResponse"/></returns>
        public Task<DescribeFwSyncStatusResponse> DescribeFwSyncStatus(DescribeFwSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeFwSyncStatusResponse>(req, "DescribeFwSyncStatus");
        }

        /// <summary>
        /// 获取防火墙同步状态，一般在执行同步操作后查询
        /// </summary>
        /// <param name="req"><see cref="DescribeFwSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeFwSyncStatusResponse"/></returns>
        public DescribeFwSyncStatusResponse DescribeFwSyncStatusSync(DescribeFwSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeFwSyncStatusResponse>(req, "DescribeFwSyncStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public Task<DescribeGuideScanInfoResponse> DescribeGuideScanInfo(DescribeGuideScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeGuideScanInfoResponse>(req, "DescribeGuideScanInfo");
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public DescribeGuideScanInfoResponse DescribeGuideScanInfoSync(DescribeGuideScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeGuideScanInfoResponse>(req, "DescribeGuideScanInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// IP防护状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public Task<DescribeIPStatusListResponse> DescribeIPStatusList(DescribeIPStatusListRequest req)
        {
            return InternalRequestAsync<DescribeIPStatusListResponse>(req, "DescribeIPStatusList");
        }

        /// <summary>
        /// IP防护状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public DescribeIPStatusListResponse DescribeIPStatusListSync(DescribeIPStatusListRequest req)
        {
            return InternalRequestAsync<DescribeIPStatusListResponse>(req, "DescribeIPStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeIdsWhiteRuleResponse"/></returns>
        public Task<DescribeIdsWhiteRuleResponse> DescribeIdsWhiteRule(DescribeIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeIdsWhiteRuleResponse>(req, "DescribeIdsWhiteRule");
        }

        /// <summary>
        /// 查询入侵防御规则白名单接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIdsWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeIdsWhiteRuleResponse"/></returns>
        public DescribeIdsWhiteRuleResponse DescribeIdsWhiteRuleSync(DescribeIdsWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeIdsWhiteRuleResponse>(req, "DescribeIdsWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 日志审计日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs");
        }

        /// <summary>
        /// 日志审计日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询NAT访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public Task<DescribeNatAcRuleResponse> DescribeNatAcRule(DescribeNatAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeNatAcRuleResponse>(req, "DescribeNatAcRule");
        }

        /// <summary>
        /// 查询NAT访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public DescribeNatAcRuleResponse DescribeNatAcRuleSync(DescribeNatAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeNatAcRuleResponse>(req, "DescribeNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前用户接入nat防火墙的所有子网数及natfw实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public Task<DescribeNatFwInfoCountResponse> DescribeNatFwInfoCount(DescribeNatFwInfoCountRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInfoCountResponse>(req, "DescribeNatFwInfoCount");
        }

        /// <summary>
        /// 获取当前用户接入nat防火墙的所有子网数及natfw实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public DescribeNatFwInfoCountResponse DescribeNatFwInfoCountSync(DescribeNatFwInfoCountRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInfoCountResponse>(req, "DescribeNatFwInfoCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeNatFwInstance 获取租户所有NAT实例
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public Task<DescribeNatFwInstanceResponse> DescribeNatFwInstance(DescribeNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceResponse>(req, "DescribeNatFwInstance");
        }

        /// <summary>
        /// DescribeNatFwInstance 获取租户所有NAT实例
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public DescribeNatFwInstanceResponse DescribeNatFwInstanceSync(DescribeNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceResponse>(req, "DescribeNatFwInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetNatFwInstanceWithRegion 获取租户新增运维的NAT实例，带上地域
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public Task<DescribeNatFwInstanceWithRegionResponse> DescribeNatFwInstanceWithRegion(DescribeNatFwInstanceWithRegionRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceWithRegionResponse>(req, "DescribeNatFwInstanceWithRegion");
        }

        /// <summary>
        /// GetNatFwInstanceWithRegion 获取租户新增运维的NAT实例，带上地域
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public DescribeNatFwInstanceWithRegionResponse DescribeNatFwInstanceWithRegionSync(DescribeNatFwInstanceWithRegionRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceWithRegionResponse>(req, "DescribeNatFwInstanceWithRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetNatInstance 获取租户所有NAT实例及实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public Task<DescribeNatFwInstancesInfoResponse> DescribeNatFwInstancesInfo(DescribeNatFwInstancesInfoRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstancesInfoResponse>(req, "DescribeNatFwInstancesInfo");
        }

        /// <summary>
        /// GetNatInstance 获取租户所有NAT实例及实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public DescribeNatFwInstancesInfoResponse DescribeNatFwInstancesInfoSync(DescribeNatFwInstancesInfoRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstancesInfoResponse>(req, "DescribeNatFwInstancesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示当前natfw 实例对应的vpc dns开关
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public Task<DescribeNatFwVpcDnsLstResponse> DescribeNatFwVpcDnsLst(DescribeNatFwVpcDnsLstRequest req)
        {
            return InternalRequestAsync<DescribeNatFwVpcDnsLstResponse>(req, "DescribeNatFwVpcDnsLst");
        }

        /// <summary>
        /// 展示当前natfw 实例对应的vpc dns开关
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public DescribeNatFwVpcDnsLstResponse DescribeNatFwVpcDnsLstSync(DescribeNatFwVpcDnsLstRequest req)
        {
            return InternalRequestAsync<DescribeNatFwVpcDnsLstResponse>(req, "DescribeNatFwVpcDnsLst")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询NAT边界防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatSwitchListRequest"/></param>
        /// <returns><see cref="DescribeNatSwitchListResponse"/></returns>
        public Task<DescribeNatSwitchListResponse> DescribeNatSwitchList(DescribeNatSwitchListRequest req)
        {
            return InternalRequestAsync<DescribeNatSwitchListResponse>(req, "DescribeNatSwitchList");
        }

        /// <summary>
        /// 查询NAT边界防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatSwitchListRequest"/></param>
        /// <returns><see cref="DescribeNatSwitchListResponse"/></returns>
        public DescribeNatSwitchListResponse DescribeNatSwitchListSync(DescribeNatSwitchListRequest req)
        {
            return InternalRequestAsync<DescribeNatSwitchListResponse>(req, "DescribeNatSwitchList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeResourceGroup资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupResponse"/></returns>
        public Task<DescribeResourceGroupResponse> DescribeResourceGroup(DescribeResourceGroupRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupResponse>(req, "DescribeResourceGroup");
        }

        /// <summary>
        /// DescribeResourceGroup资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupResponse"/></returns>
        public DescribeResourceGroupResponse DescribeResourceGroupSync(DescribeResourceGroupRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupResponse>(req, "DescribeResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeResourceGroupNew资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public Task<DescribeResourceGroupNewResponse> DescribeResourceGroupNew(DescribeResourceGroupNewRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupNewResponse>(req, "DescribeResourceGroupNew");
        }

        /// <summary>
        /// DescribeResourceGroupNew资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public DescribeResourceGroupNewResponse DescribeResourceGroupNewSync(DescribeResourceGroupNewRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupNewResponse>(req, "DescribeResourceGroupNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRuleOverviewResponse>(req, "DescribeRuleOverview");
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRuleOverviewResponse>(req, "DescribeRuleOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public Task<DescribeSecurityGroupListResponse> DescribeSecurityGroupList(DescribeSecurityGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupListResponse>(req, "DescribeSecurityGroupList");
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public DescribeSecurityGroupListResponse DescribeSecurityGroupListSync(DescribeSecurityGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupListResponse>(req, "DescribeSecurityGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeSourceAsset-查询全部资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public Task<DescribeSourceAssetResponse> DescribeSourceAsset(DescribeSourceAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceAssetResponse>(req, "DescribeSourceAsset");
        }

        /// <summary>
        /// DescribeSourceAsset-查询全部资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public DescribeSourceAssetResponse DescribeSourceAssetSync(DescribeSourceAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceAssetResponse>(req, "DescribeSourceAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 防火墙开关列表，已废弃，请使用DescribeFwEdgeIps
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
            return InternalRequestAsync<DescribeSwitchListsResponse>(req, "DescribeSwitchLists");
        }

        /// <summary>
        /// 防火墙开关列表，已废弃，请使用DescribeFwEdgeIps
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
            return InternalRequestAsync<DescribeSwitchListsResponse>(req, "DescribeSwitchLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public Task<DescribeTLogInfoResponse> DescribeTLogInfo(DescribeTLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeTLogInfoResponse>(req, "DescribeTLogInfo");
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public DescribeTLogInfoResponse DescribeTLogInfoSync(DescribeTLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeTLogInfoResponse>(req, "DescribeTLogInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public Task<DescribeTLogIpListResponse> DescribeTLogIpList(DescribeTLogIpListRequest req)
        {
            return InternalRequestAsync<DescribeTLogIpListResponse>(req, "DescribeTLogIpList");
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public DescribeTLogIpListResponse DescribeTLogIpListSync(DescribeTLogIpListRequest req)
        {
            return InternalRequestAsync<DescribeTLogIpListResponse>(req, "DescribeTLogIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
            return InternalRequestAsync<DescribeTableStatusResponse>(req, "DescribeTableStatus");
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
            return InternalRequestAsync<DescribeTableStatusResponse>(req, "DescribeTableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public Task<DescribeUnHandleEventTabListResponse> DescribeUnHandleEventTabList(DescribeUnHandleEventTabListRequest req)
        {
            return InternalRequestAsync<DescribeUnHandleEventTabListResponse>(req, "DescribeUnHandleEventTabList");
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public DescribeUnHandleEventTabListResponse DescribeUnHandleEventTabListSync(DescribeUnHandleEventTabListRequest req)
        {
            return InternalRequestAsync<DescribeUnHandleEventTabListResponse>(req, "DescribeUnHandleEventTabList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询内网间访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAcRuleRequest"/></param>
        /// <returns><see cref="DescribeVpcAcRuleResponse"/></returns>
        public Task<DescribeVpcAcRuleResponse> DescribeVpcAcRule(DescribeVpcAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeVpcAcRuleResponse>(req, "DescribeVpcAcRule");
        }

        /// <summary>
        /// 查询内网间访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAcRuleRequest"/></param>
        /// <returns><see cref="DescribeVpcAcRuleResponse"/></returns>
        public DescribeVpcAcRuleResponse DescribeVpcAcRuleSync(DescribeVpcAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeVpcAcRuleResponse>(req, "DescribeVpcAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// VPC防火墙(组)开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcFwGroupSwitchRequest"/></param>
        /// <returns><see cref="DescribeVpcFwGroupSwitchResponse"/></returns>
        public Task<DescribeVpcFwGroupSwitchResponse> DescribeVpcFwGroupSwitch(DescribeVpcFwGroupSwitchRequest req)
        {
            return InternalRequestAsync<DescribeVpcFwGroupSwitchResponse>(req, "DescribeVpcFwGroupSwitch");
        }

        /// <summary>
        /// VPC防火墙(组)开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcFwGroupSwitchRequest"/></param>
        /// <returns><see cref="DescribeVpcFwGroupSwitchResponse"/></returns>
        public DescribeVpcFwGroupSwitchResponse DescribeVpcFwGroupSwitchSync(DescribeVpcFwGroupSwitchRequest req)
        {
            return InternalRequestAsync<DescribeVpcFwGroupSwitchResponse>(req, "DescribeVpcFwGroupSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public Task<ExpandCfwVerticalResponse> ExpandCfwVertical(ExpandCfwVerticalRequest req)
        {
            return InternalRequestAsync<ExpandCfwVerticalResponse>(req, "ExpandCfwVertical");
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public ExpandCfwVerticalResponse ExpandCfwVerticalSync(ExpandCfwVerticalRequest req)
        {
            return InternalRequestAsync<ExpandCfwVerticalResponse>(req, "ExpandCfwVertical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyAcRuleResponse>(req, "ModifyAcRule");
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyAcRuleResponse>(req, "ModifyAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public Task<ModifyAclRuleResponse> ModifyAclRule(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule");
        }

        /// <summary>
        /// 修改互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public ModifyAclRuleResponse ModifyAclRuleSync(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改地址模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateResponse"/></returns>
        public Task<ModifyAddressTemplateResponse> ModifyAddressTemplate(ModifyAddressTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateResponse>(req, "ModifyAddressTemplate");
        }

        /// <summary>
        /// 修改地址模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateResponse"/></returns>
        public ModifyAddressTemplateResponse ModifyAddressTemplateSync(ModifyAddressTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateResponse>(req, "ModifyAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 互联网边界防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public Task<ModifyAllPublicIPSwitchStatusResponse> ModifyAllPublicIPSwitchStatus(ModifyAllPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllPublicIPSwitchStatusResponse>(req, "ModifyAllPublicIPSwitchStatus");
        }

        /// <summary>
        /// 互联网边界防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public ModifyAllPublicIPSwitchStatusResponse ModifyAllPublicIPSwitchStatusSync(ModifyAllPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllPublicIPSwitchStatusResponse>(req, "ModifyAllPublicIPSwitchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllRuleStatusResponse>(req, "ModifyAllRuleStatus");
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllRuleStatusResponse>(req, "ModifyAllRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// VPC防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public Task<ModifyAllVPCSwitchStatusResponse> ModifyAllVPCSwitchStatus(ModifyAllVPCSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllVPCSwitchStatusResponse>(req, "ModifyAllVPCSwitchStatus");
        }

        /// <summary>
        /// VPC防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public ModifyAllVPCSwitchStatusResponse ModifyAllVPCSwitchStatusSync(ModifyAllVPCSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllVPCSwitchStatusResponse>(req, "ModifyAllVPCSwitchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public Task<ModifyAssetScanResponse> ModifyAssetScan(ModifyAssetScanRequest req)
        {
            return InternalRequestAsync<ModifyAssetScanResponse>(req, "ModifyAssetScan");
        }

        /// <summary>
        /// 资产扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public ModifyAssetScanResponse ModifyAssetScanSync(ModifyAssetScanRequest req)
        {
            return InternalRequestAsync<ModifyAssetScanResponse>(req, "ModifyAssetScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产同步
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetSyncRequest"/></param>
        /// <returns><see cref="ModifyAssetSyncResponse"/></returns>
        public Task<ModifyAssetSyncResponse> ModifyAssetSync(ModifyAssetSyncRequest req)
        {
            return InternalRequestAsync<ModifyAssetSyncResponse>(req, "ModifyAssetSync");
        }

        /// <summary>
        /// 资产同步
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetSyncRequest"/></param>
        /// <returns><see cref="ModifyAssetSyncResponse"/></returns>
        public ModifyAssetSyncResponse ModifyAssetSyncSync(ModifyAssetSyncRequest req)
        {
            return InternalRequestAsync<ModifyAssetSyncResponse>(req, "ModifyAssetSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持对封禁列表、放通列表如下操作：
        /// 批量增加封禁IP、放通IP/域名
        /// 批量删除封禁IP、放通IP/域名
        /// 批量修改封禁IP、放通IP/域名生效事件
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public Task<ModifyBlockIgnoreListResponse> ModifyBlockIgnoreList(ModifyBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreListResponse>(req, "ModifyBlockIgnoreList");
        }

        /// <summary>
        /// 支持对封禁列表、放通列表如下操作：
        /// 批量增加封禁IP、放通IP/域名
        /// 批量删除封禁IP、放通IP/域名
        /// 批量修改封禁IP、放通IP/域名生效事件
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public ModifyBlockIgnoreListResponse ModifyBlockIgnoreListSync(ModifyBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreListResponse>(req, "ModifyBlockIgnoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑单条入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreRuleRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreRuleResponse"/></returns>
        public Task<ModifyBlockIgnoreRuleResponse> ModifyBlockIgnoreRule(ModifyBlockIgnoreRuleRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreRuleResponse>(req, "ModifyBlockIgnoreRule");
        }

        /// <summary>
        /// 编辑单条入侵防御封禁列表、放通列表规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreRuleRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreRuleResponse"/></returns>
        public ModifyBlockIgnoreRuleResponse ModifyBlockIgnoreRuleSync(ModifyBlockIgnoreRuleRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreRuleResponse>(req, "ModifyBlockIgnoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑单条入侵防御封禁列表、放通列表规则（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreRuleNewResponse"/></returns>
        public Task<ModifyBlockIgnoreRuleNewResponse> ModifyBlockIgnoreRuleNew(ModifyBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreRuleNewResponse>(req, "ModifyBlockIgnoreRuleNew");
        }

        /// <summary>
        /// 编辑单条入侵防御封禁列表、放通列表规则（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreRuleNewRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreRuleNewResponse"/></returns>
        public ModifyBlockIgnoreRuleNewResponse ModifyBlockIgnoreRuleNewSync(ModifyBlockIgnoreRuleNewRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreRuleNewResponse>(req, "ModifyBlockIgnoreRuleNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public Task<ModifyBlockTopResponse> ModifyBlockTop(ModifyBlockTopRequest req)
        {
            return InternalRequestAsync<ModifyBlockTopResponse>(req, "ModifyBlockTop");
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public ModifyBlockTopResponse ModifyBlockTopSync(ModifyBlockTopRequest req)
        {
            return InternalRequestAsync<ModifyBlockTopResponse>(req, "ModifyBlockTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用停用VPC间规则或Nat边界规则
        /// VPC间规则需指定EdgeId。Nat边界规则需指定地域Region与Direction。
        /// </summary>
        /// <param name="req"><see cref="ModifyEWRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEWRuleStatusResponse"/></returns>
        public Task<ModifyEWRuleStatusResponse> ModifyEWRuleStatus(ModifyEWRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEWRuleStatusResponse>(req, "ModifyEWRuleStatus");
        }

        /// <summary>
        /// 启用停用VPC间规则或Nat边界规则
        /// VPC间规则需指定EdgeId。Nat边界规则需指定地域Region与Direction。
        /// </summary>
        /// <param name="req"><see cref="ModifyEWRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEWRuleStatusResponse"/></returns>
        public ModifyEWRuleStatusResponse ModifyEWRuleStatusSync(ModifyEWRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEWRuleStatusResponse>(req, "ModifyEWRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边界防火墙开关(旁路、串行)
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeIpSwitchRequest"/></param>
        /// <returns><see cref="ModifyEdgeIpSwitchResponse"/></returns>
        public Task<ModifyEdgeIpSwitchResponse> ModifyEdgeIpSwitch(ModifyEdgeIpSwitchRequest req)
        {
            return InternalRequestAsync<ModifyEdgeIpSwitchResponse>(req, "ModifyEdgeIpSwitch");
        }

        /// <summary>
        /// 修改边界防火墙开关(旁路、串行)
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeIpSwitchRequest"/></param>
        /// <returns><see cref="ModifyEdgeIpSwitchResponse"/></returns>
        public ModifyEdgeIpSwitchResponse ModifyEdgeIpSwitchSync(ModifyEdgeIpSwitchRequest req)
        {
            return InternalRequestAsync<ModifyEdgeIpSwitchResponse>(req, "ModifyEdgeIpSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改企业安全组下发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public Task<ModifyEnterpriseSecurityDispatchStatusResponse> ModifyEnterpriseSecurityDispatchStatus(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityDispatchStatusResponse>(req, "ModifyEnterpriseSecurityDispatchStatus");
        }

        /// <summary>
        /// 修改企业安全组下发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public ModifyEnterpriseSecurityDispatchStatusResponse ModifyEnterpriseSecurityDispatchStatusSync(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityDispatchStatusResponse>(req, "ModifyEnterpriseSecurityDispatchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<ModifyEnterpriseSecurityGroupRuleResponse> ModifyEnterpriseSecurityGroupRule(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityGroupRuleResponse>(req, "ModifyEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// 编辑新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public ModifyEnterpriseSecurityGroupRuleResponse ModifyEnterpriseSecurityGroupRuleSync(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityGroupRuleResponse>(req, "ModifyEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改防火墙(组)开关(支持单点模式、多点模式、全互通模式)
        /// </summary>
        /// <param name="req"><see cref="ModifyFwGroupSwitchRequest"/></param>
        /// <returns><see cref="ModifyFwGroupSwitchResponse"/></returns>
        public Task<ModifyFwGroupSwitchResponse> ModifyFwGroupSwitch(ModifyFwGroupSwitchRequest req)
        {
            return InternalRequestAsync<ModifyFwGroupSwitchResponse>(req, "ModifyFwGroupSwitch");
        }

        /// <summary>
        /// 修改防火墙(组)开关(支持单点模式、多点模式、全互通模式)
        /// </summary>
        /// <param name="req"><see cref="ModifyFwGroupSwitchRequest"/></param>
        /// <returns><see cref="ModifyFwGroupSwitchResponse"/></returns>
        public ModifyFwGroupSwitchResponse ModifyFwGroupSwitchSync(ModifyFwGroupSwitchRequest req)
        {
            return InternalRequestAsync<ModifyFwGroupSwitchResponse>(req, "ModifyFwGroupSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public Task<ModifyNatAcRuleResponse> ModifyNatAcRule(ModifyNatAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAcRuleResponse>(req, "ModifyNatAcRule");
        }

        /// <summary>
        /// 修改NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public ModifyNatAcRuleResponse ModifyNatAcRuleSync(ModifyNatAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAcRuleResponse>(req, "ModifyNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 防火墙实例重新选择vpc或nat
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public Task<ModifyNatFwReSelectResponse> ModifyNatFwReSelect(ModifyNatFwReSelectRequest req)
        {
            return InternalRequestAsync<ModifyNatFwReSelectResponse>(req, "ModifyNatFwReSelect");
        }

        /// <summary>
        /// 防火墙实例重新选择vpc或nat
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public ModifyNatFwReSelectResponse ModifyNatFwReSelectSync(ModifyNatFwReSelectRequest req)
        {
            return InternalRequestAsync<ModifyNatFwReSelectResponse>(req, "ModifyNatFwReSelect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改NAT防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public Task<ModifyNatFwSwitchResponse> ModifyNatFwSwitch(ModifyNatFwSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwSwitchResponse>(req, "ModifyNatFwSwitch");
        }

        /// <summary>
        /// 修改NAT防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public ModifyNatFwSwitchResponse ModifyNatFwSwitchSync(ModifyNatFwSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwSwitchResponse>(req, "ModifyNatFwSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// nat 防火墙VPC DNS 开关切换
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public Task<ModifyNatFwVpcDnsSwitchResponse> ModifyNatFwVpcDnsSwitch(ModifyNatFwVpcDnsSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwVpcDnsSwitchResponse>(req, "ModifyNatFwVpcDnsSwitch");
        }

        /// <summary>
        /// nat 防火墙VPC DNS 开关切换
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public ModifyNatFwVpcDnsSwitchResponse ModifyNatFwVpcDnsSwitchSync(ModifyNatFwVpcDnsSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwVpcDnsSwitchResponse>(req, "ModifyNatFwVpcDnsSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑NAT防火墙
        /// </summary>
        /// <param name="req"><see cref="ModifyNatInstanceRequest"/></param>
        /// <returns><see cref="ModifyNatInstanceResponse"/></returns>
        public Task<ModifyNatInstanceResponse> ModifyNatInstance(ModifyNatInstanceRequest req)
        {
            return InternalRequestAsync<ModifyNatInstanceResponse>(req, "ModifyNatInstance");
        }

        /// <summary>
        /// 编辑NAT防火墙
        /// </summary>
        /// <param name="req"><see cref="ModifyNatInstanceRequest"/></param>
        /// <returns><see cref="ModifyNatInstanceResponse"/></returns>
        public ModifyNatInstanceResponse ModifyNatInstanceSync(ModifyNatInstanceRequest req)
        {
            return InternalRequestAsync<ModifyNatInstanceResponse>(req, "ModifyNatInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT防火墙规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public Task<ModifyNatSequenceRulesResponse> ModifyNatSequenceRules(ModifyNatSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyNatSequenceRulesResponse>(req, "ModifyNatSequenceRules");
        }

        /// <summary>
        /// NAT防火墙规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public ModifyNatSequenceRulesResponse ModifyNatSequenceRulesSync(ModifyNatSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyNatSequenceRulesResponse>(req, "ModifyNatSequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyResourceGroup-资产中心资产组信息修改
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public Task<ModifyResourceGroupResponse> ModifyResourceGroup(ModifyResourceGroupRequest req)
        {
            return InternalRequestAsync<ModifyResourceGroupResponse>(req, "ModifyResourceGroup");
        }

        /// <summary>
        /// ModifyResourceGroup-资产中心资产组信息修改
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public ModifyResourceGroupResponse ModifyResourceGroupSync(ModifyResourceGroupRequest req)
        {
            return InternalRequestAsync<ModifyResourceGroupResponse>(req, "ModifyResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步资产-互联网&VPC（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public Task<ModifyRunSyncAssetResponse> ModifyRunSyncAsset(ModifyRunSyncAssetRequest req)
        {
            return InternalRequestAsync<ModifyRunSyncAssetResponse>(req, "ModifyRunSyncAsset");
        }

        /// <summary>
        /// 同步资产-互联网&VPC（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public ModifyRunSyncAssetResponse ModifyRunSyncAssetSync(ModifyRunSyncAssetRequest req)
        {
            return InternalRequestAsync<ModifyRunSyncAssetResponse>(req, "ModifyRunSyncAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用停用单条企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public Task<ModifySecurityGroupItemRuleStatusResponse> ModifySecurityGroupItemRuleStatus(ModifySecurityGroupItemRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupItemRuleStatusResponse>(req, "ModifySecurityGroupItemRuleStatus");
        }

        /// <summary>
        /// 启用停用单条企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public ModifySecurityGroupItemRuleStatusResponse ModifySecurityGroupItemRuleStatusSync(ModifySecurityGroupItemRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupItemRuleStatusResponse>(req, "ModifySecurityGroupItemRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑单条安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public Task<ModifySecurityGroupRuleResponse> ModifySecurityGroupRule(ModifySecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupRuleResponse>(req, "ModifySecurityGroupRule");
        }

        /// <summary>
        /// 编辑单条安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public ModifySecurityGroupRuleResponse ModifySecurityGroupRuleSync(ModifySecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupRuleResponse>(req, "ModifySecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业安全组规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public Task<ModifySecurityGroupSequenceRulesResponse> ModifySecurityGroupSequenceRules(ModifySecurityGroupSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupSequenceRulesResponse>(req, "ModifySecurityGroupSequenceRules");
        }

        /// <summary>
        /// 企业安全组规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public ModifySecurityGroupSequenceRulesResponse ModifySecurityGroupSequenceRulesSync(ModifySecurityGroupSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupSequenceRulesResponse>(req, "ModifySecurityGroupSequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 互联网边界规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceAclRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceAclRulesResponse"/></returns>
        public Task<ModifySequenceAclRulesResponse> ModifySequenceAclRules(ModifySequenceAclRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceAclRulesResponse>(req, "ModifySequenceAclRules");
        }

        /// <summary>
        /// 互联网边界规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceAclRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceAclRulesResponse"/></returns>
        public ModifySequenceAclRulesResponse ModifySequenceAclRulesSync(ModifySequenceAclRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceAclRulesResponse>(req, "ModifySequenceAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceRulesResponse>(req, "ModifySequenceRules");
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceRulesResponse>(req, "ModifySequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 日志存储设置，可以修改存储时间和清空日志
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public Task<ModifyStorageSettingResponse> ModifyStorageSetting(ModifyStorageSettingRequest req)
        {
            return InternalRequestAsync<ModifyStorageSettingResponse>(req, "ModifyStorageSetting");
        }

        /// <summary>
        /// 日志存储设置，可以修改存储时间和清空日志
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public ModifyStorageSettingResponse ModifyStorageSettingSync(ModifyStorageSettingRequest req)
        {
            return InternalRequestAsync<ModifyStorageSettingResponse>(req, "ModifyStorageSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
            return InternalRequestAsync<ModifyTableStatusResponse>(req, "ModifyTableStatus");
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
            return InternalRequestAsync<ModifyTableStatusResponse>(req, "ModifyTableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改内网间访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAcRuleRequest"/></param>
        /// <returns><see cref="ModifyVpcAcRuleResponse"/></returns>
        public Task<ModifyVpcAcRuleResponse> ModifyVpcAcRule(ModifyVpcAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyVpcAcRuleResponse>(req, "ModifyVpcAcRule");
        }

        /// <summary>
        /// 修改内网间访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAcRuleRequest"/></param>
        /// <returns><see cref="ModifyVpcAcRuleResponse"/></returns>
        public ModifyVpcAcRuleResponse ModifyVpcAcRuleSync(ModifyVpcAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyVpcAcRuleResponse>(req, "ModifyVpcAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑VPC间防火墙(防火墙组)
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcFwGroupRequest"/></param>
        /// <returns><see cref="ModifyVpcFwGroupResponse"/></returns>
        public Task<ModifyVpcFwGroupResponse> ModifyVpcFwGroup(ModifyVpcFwGroupRequest req)
        {
            return InternalRequestAsync<ModifyVpcFwGroupResponse>(req, "ModifyVpcFwGroup");
        }

        /// <summary>
        /// 编辑VPC间防火墙(防火墙组)
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcFwGroupRequest"/></param>
        /// <returns><see cref="ModifyVpcFwGroupResponse"/></returns>
        public ModifyVpcFwGroupResponse ModifyVpcFwGroupSync(ModifyVpcFwGroupRequest req)
        {
            return InternalRequestAsync<ModifyVpcFwGroupResponse>(req, "ModifyVpcFwGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// vpc间规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcFwSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyVpcFwSequenceRulesResponse"/></returns>
        public Task<ModifyVpcFwSequenceRulesResponse> ModifyVpcFwSequenceRules(ModifyVpcFwSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyVpcFwSequenceRulesResponse>(req, "ModifyVpcFwSequenceRules");
        }

        /// <summary>
        /// vpc间规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcFwSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyVpcFwSequenceRulesResponse"/></returns>
        public ModifyVpcFwSequenceRulesResponse ModifyVpcFwSequenceRulesSync(ModifyVpcFwSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyVpcFwSequenceRulesResponse>(req, "ModifyVpcFwSequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public Task<RemoveAcRuleResponse> RemoveAcRule(RemoveAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveAcRuleResponse>(req, "RemoveAcRule");
        }

        /// <summary>
        /// 删除互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public RemoveAcRuleResponse RemoveAcRuleSync(RemoveAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveAcRuleResponse>(req, "RemoveAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAclRuleRequest"/></param>
        /// <returns><see cref="RemoveAclRuleResponse"/></returns>
        public Task<RemoveAclRuleResponse> RemoveAclRule(RemoveAclRuleRequest req)
        {
            return InternalRequestAsync<RemoveAclRuleResponse>(req, "RemoveAclRule");
        }

        /// <summary>
        /// 删除互联网边界访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAclRuleRequest"/></param>
        /// <returns><see cref="RemoveAclRuleResponse"/></returns>
        public RemoveAclRuleResponse RemoveAclRuleSync(RemoveAclRuleRequest req)
        {
            return InternalRequestAsync<RemoveAclRuleResponse>(req, "RemoveAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<RemoveEnterpriseSecurityGroupRuleResponse> RemoveEnterpriseSecurityGroupRule(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<RemoveEnterpriseSecurityGroupRuleResponse>(req, "RemoveEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// 删除新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public RemoveEnterpriseSecurityGroupRuleResponse RemoveEnterpriseSecurityGroupRuleSync(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<RemoveEnterpriseSecurityGroupRuleResponse>(req, "RemoveEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public Task<RemoveNatAcRuleResponse> RemoveNatAcRule(RemoveNatAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveNatAcRuleResponse>(req, "RemoveNatAcRule");
        }

        /// <summary>
        /// 删除NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public RemoveNatAcRuleResponse RemoveNatAcRuleSync(RemoveNatAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveNatAcRuleResponse>(req, "RemoveNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除VPC间规则
        /// </summary>
        /// <param name="req"><see cref="RemoveVpcAcRuleRequest"/></param>
        /// <returns><see cref="RemoveVpcAcRuleResponse"/></returns>
        public Task<RemoveVpcAcRuleResponse> RemoveVpcAcRule(RemoveVpcAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveVpcAcRuleResponse>(req, "RemoveVpcAcRule");
        }

        /// <summary>
        /// 删除VPC间规则
        /// </summary>
        /// <param name="req"><see cref="RemoveVpcAcRuleRequest"/></param>
        /// <returns><see cref="RemoveVpcAcRuleResponse"/></returns>
        public RemoveVpcAcRuleResponse RemoveVpcAcRuleSync(RemoveVpcAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveVpcAcRuleResponse>(req, "RemoveVpcAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public Task<SetNatFwDnatRuleResponse> SetNatFwDnatRule(SetNatFwDnatRuleRequest req)
        {
            return InternalRequestAsync<SetNatFwDnatRuleResponse>(req, "SetNatFwDnatRule");
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public SetNatFwDnatRuleResponse SetNatFwDnatRuleSync(SetNatFwDnatRuleRequest req)
        {
            return InternalRequestAsync<SetNatFwDnatRuleResponse>(req, "SetNatFwDnatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置防火墙实例弹性公网ip，目前仅支持新增模式的防火墙实例
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public Task<SetNatFwEipResponse> SetNatFwEip(SetNatFwEipRequest req)
        {
            return InternalRequestAsync<SetNatFwEipResponse>(req, "SetNatFwEip");
        }

        /// <summary>
        /// 设置防火墙实例弹性公网ip，目前仅支持新增模式的防火墙实例
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public SetNatFwEipResponse SetNatFwEipSync(SetNatFwEipRequest req)
        {
            return InternalRequestAsync<SetNatFwEipResponse>(req, "SetNatFwEip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 中止安全组规则下发
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public Task<StopSecurityGroupRuleDispatchResponse> StopSecurityGroupRuleDispatch(StopSecurityGroupRuleDispatchRequest req)
        {
            return InternalRequestAsync<StopSecurityGroupRuleDispatchResponse>(req, "StopSecurityGroupRuleDispatch");
        }

        /// <summary>
        /// 中止安全组规则下发
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public StopSecurityGroupRuleDispatchResponse StopSecurityGroupRuleDispatchSync(StopSecurityGroupRuleDispatchRequest req)
        {
            return InternalRequestAsync<StopSecurityGroupRuleDispatchResponse>(req, "StopSecurityGroupRuleDispatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步防火墙操作，包括同步防火墙路由（若vpc，专线网关等增加了Cidr，需要手动同步一下路由使之在防火墙上生效）等。
        /// </summary>
        /// <param name="req"><see cref="SyncFwOperateRequest"/></param>
        /// <returns><see cref="SyncFwOperateResponse"/></returns>
        public Task<SyncFwOperateResponse> SyncFwOperate(SyncFwOperateRequest req)
        {
            return InternalRequestAsync<SyncFwOperateResponse>(req, "SyncFwOperate");
        }

        /// <summary>
        /// 同步防火墙操作，包括同步防火墙路由（若vpc，专线网关等增加了Cidr，需要手动同步一下路由使之在防火墙上生效）等。
        /// </summary>
        /// <param name="req"><see cref="SyncFwOperateRequest"/></param>
        /// <returns><see cref="SyncFwOperateResponse"/></returns>
        public SyncFwOperateResponse SyncFwOperateSync(SyncFwOperateRequest req)
        {
            return InternalRequestAsync<SyncFwOperateResponse>(req, "SyncFwOperate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
