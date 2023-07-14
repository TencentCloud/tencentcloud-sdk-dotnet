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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 添加互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public async Task<AddAcRuleResponse> AddAcRule(AddAcRuleRequest req)
        {
             JsonResponseModel<AddAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public AddAcRuleResponse AddAcRuleSync(AddAcRuleRequest req)
        {
             JsonResponseModel<AddAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public async Task<AddEnterpriseSecurityGroupRulesResponse> AddEnterpriseSecurityGroupRules(AddEnterpriseSecurityGroupRulesRequest req)
        {
             JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEnterpriseSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public AddEnterpriseSecurityGroupRulesResponse AddEnterpriseSecurityGroupRulesSync(AddEnterpriseSecurityGroupRulesRequest req)
        {
             JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEnterpriseSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加nat访问控制规则(地域必填)
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public async Task<AddNatAcRuleResponse> AddNatAcRule(AddNatAcRuleRequest req)
        {
             JsonResponseModel<AddNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加nat访问控制规则(地域必填)
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public AddNatAcRuleResponse AddNatAcRuleSync(AddNatAcRuleRequest req)
        {
             JsonResponseModel<AddNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public async Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建地址模板规则
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public async Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建地址模板规则
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建、选择vpc
        /// </summary>
        /// <param name="req"><see cref="CreateChooseVpcsRequest"/></param>
        /// <returns><see cref="CreateChooseVpcsResponse"/></returns>
        public async Task<CreateChooseVpcsResponse> CreateChooseVpcs(CreateChooseVpcsRequest req)
        {
             JsonResponseModel<CreateChooseVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateChooseVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChooseVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建、选择vpc
        /// </summary>
        /// <param name="req"><see cref="CreateChooseVpcsRequest"/></param>
        /// <returns><see cref="CreateChooseVpcsResponse"/></returns>
        public CreateChooseVpcsResponse CreateChooseVpcsSync(CreateChooseVpcsRequest req)
        {
             JsonResponseModel<CreateChooseVpcsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateChooseVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChooseVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建暴露数据库白名单规则
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseWhiteListRulesRequest"/></param>
        /// <returns><see cref="CreateDatabaseWhiteListRulesResponse"/></returns>
        public async Task<CreateDatabaseWhiteListRulesResponse> CreateDatabaseWhiteListRules(CreateDatabaseWhiteListRulesRequest req)
        {
             JsonResponseModel<CreateDatabaseWhiteListRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatabaseWhiteListRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseWhiteListRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建暴露数据库白名单规则
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseWhiteListRulesRequest"/></param>
        /// <returns><see cref="CreateDatabaseWhiteListRulesResponse"/></returns>
        public CreateDatabaseWhiteListRulesResponse CreateDatabaseWhiteListRulesSync(CreateDatabaseWhiteListRulesRequest req)
        {
             JsonResponseModel<CreateDatabaseWhiteListRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatabaseWhiteListRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseWhiteListRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建NAT防火墙实例（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public async Task<CreateNatFwInstanceResponse> CreateNatFwInstance(CreateNatFwInstanceRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建NAT防火墙实例（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public CreateNatFwInstanceResponse CreateNatFwInstanceSync(CreateNatFwInstanceRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建防火墙实例和接入域名（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public async Task<CreateNatFwInstanceWithDomainResponse> CreateNatFwInstanceWithDomain(CreateNatFwInstanceWithDomainRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceWithDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatFwInstanceWithDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceWithDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建防火墙实例和接入域名（Region参数必填）
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public CreateNatFwInstanceWithDomainResponse CreateNatFwInstanceWithDomainSync(CreateNatFwInstanceWithDomainRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceWithDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatFwInstanceWithDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceWithDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public async Task<CreateSecurityGroupRulesResponse> CreateSecurityGroupRules(CreateSecurityGroupRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public CreateSecurityGroupRulesResponse CreateSecurityGroupRulesSync(CreateSecurityGroupRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public async Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除地址模板规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public async Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除地址模板规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public async Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNatFwInstanceRequest"/></param>
        /// <returns><see cref="DeleteNatFwInstanceResponse"/></returns>
        public async Task<DeleteNatFwInstanceResponse> DeleteNatFwInstance(DeleteNatFwInstanceRequest req)
        {
             JsonResponseModel<DeleteNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNatFwInstanceRequest"/></param>
        /// <returns><see cref="DeleteNatFwInstanceResponse"/></returns>
        public DeleteNatFwInstanceResponse DeleteNatFwInstanceSync(DeleteNatFwInstanceRequest req)
        {
             JsonResponseModel<DeleteNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteResourceGroup-资产中心资产组删除
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteResourceGroup-资产中心资产组删除
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public async Task<DeleteVpcInstanceResponse> DeleteVpcInstance(DeleteVpcInstanceRequest req)
        {
             JsonResponseModel<DeleteVpcInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防火墙实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public DeleteVpcInstanceResponse DeleteVpcInstanceSync(DeleteVpcInstanceRequest req)
        {
             JsonResponseModel<DeleteVpcInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public async Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public async Task<DescribeAssociatedInstanceListResponse> DescribeAssociatedInstanceList(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public DescribeAssociatedInstanceListResponse DescribeAssociatedInstanceListSync(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public async Task<DescribeBlockByIpTimesListResponse> DescribeBlockByIpTimesList(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public DescribeBlockByIpTimesListResponse DescribeBlockByIpTimesListSync(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询入侵防御放通封禁列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public async Task<DescribeBlockIgnoreListResponse> DescribeBlockIgnoreList(DescribeBlockIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询入侵防御放通封禁列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public DescribeBlockIgnoreListResponse DescribeBlockIgnoreListSync(DescribeBlockIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public async Task<DescribeBlockStaticListResponse> DescribeBlockStaticList(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public DescribeBlockStaticListResponse DescribeBlockStaticListSync(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public async Task<DescribeCfwEipsResponse> DescribeCfwEips(DescribeCfwEipsRequest req)
        {
             JsonResponseModel<DescribeCfwEipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfwEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfwEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public DescribeCfwEipsResponse DescribeCfwEipsSync(DescribeCfwEipsRequest req)
        {
             JsonResponseModel<DescribeCfwEipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfwEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfwEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取入侵防御按钮列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public async Task<DescribeDefenseSwitchResponse> DescribeDefenseSwitch(DescribeDefenseSwitchRequest req)
        {
             JsonResponseModel<DescribeDefenseSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefenseSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenseSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取入侵防御按钮列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public DescribeDefenseSwitchResponse DescribeDefenseSwitchSync(DescribeDefenseSwitchRequest req)
        {
             JsonResponseModel<DescribeDefenseSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefenseSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenseSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新版安全组下发进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSGRuleProgressRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSGRuleProgressResponse"/></returns>
        public async Task<DescribeEnterpriseSGRuleProgressResponse> DescribeEnterpriseSGRuleProgress(DescribeEnterpriseSGRuleProgressRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSGRuleProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnterpriseSGRuleProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSGRuleProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新版安全组下发进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSGRuleProgressRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSGRuleProgressResponse"/></returns>
        public DescribeEnterpriseSGRuleProgressResponse DescribeEnterpriseSGRuleProgressSync(DescribeEnterpriseSGRuleProgressRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSGRuleProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnterpriseSGRuleProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSGRuleProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public async Task<DescribeEnterpriseSecurityGroupRuleResponse> DescribeEnterpriseSecurityGroupRule(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public DescribeEnterpriseSecurityGroupRuleResponse DescribeEnterpriseSecurityGroupRuleSync(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public async Task<DescribeGuideScanInfoResponse> DescribeGuideScanInfo(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public DescribeGuideScanInfoResponse DescribeGuideScanInfoSync(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ip防护状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public async Task<DescribeIPStatusListResponse> DescribeIPStatusList(DescribeIPStatusListRequest req)
        {
             JsonResponseModel<DescribeIPStatusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ip防护状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public DescribeIPStatusListResponse DescribeIPStatusListSync(DescribeIPStatusListRequest req)
        {
             JsonResponseModel<DescribeIPStatusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志审计日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public async Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志审计日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询NAT访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public async Task<DescribeNatAcRuleResponse> DescribeNatAcRule(DescribeNatAcRuleRequest req)
        {
             JsonResponseModel<DescribeNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询NAT访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public DescribeNatAcRuleResponse DescribeNatAcRuleSync(DescribeNatAcRuleRequest req)
        {
             JsonResponseModel<DescribeNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前用户接入nat防火墙的所有子网数及natfw实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public async Task<DescribeNatFwInfoCountResponse> DescribeNatFwInfoCount(DescribeNatFwInfoCountRequest req)
        {
             JsonResponseModel<DescribeNatFwInfoCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInfoCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInfoCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前用户接入nat防火墙的所有子网数及natfw实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public DescribeNatFwInfoCountResponse DescribeNatFwInfoCountSync(DescribeNatFwInfoCountRequest req)
        {
             JsonResponseModel<DescribeNatFwInfoCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInfoCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInfoCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeNatFwInstance 获取租户所有NAT实例
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public async Task<DescribeNatFwInstanceResponse> DescribeNatFwInstance(DescribeNatFwInstanceRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeNatFwInstance 获取租户所有NAT实例
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public DescribeNatFwInstanceResponse DescribeNatFwInstanceSync(DescribeNatFwInstanceRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetNatFwInstanceWithRegion 获取租户新增运维的NAT实例，带上地域
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public async Task<DescribeNatFwInstanceWithRegionResponse> DescribeNatFwInstanceWithRegion(DescribeNatFwInstanceWithRegionRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceWithRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstanceWithRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceWithRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetNatFwInstanceWithRegion 获取租户新增运维的NAT实例，带上地域
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public DescribeNatFwInstanceWithRegionResponse DescribeNatFwInstanceWithRegionSync(DescribeNatFwInstanceWithRegionRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceWithRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstanceWithRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceWithRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetNatInstance 获取租户所有NAT实例及实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public async Task<DescribeNatFwInstancesInfoResponse> DescribeNatFwInstancesInfo(DescribeNatFwInstancesInfoRequest req)
        {
             JsonResponseModel<DescribeNatFwInstancesInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstancesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstancesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetNatInstance 获取租户所有NAT实例及实例卡片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public DescribeNatFwInstancesInfoResponse DescribeNatFwInstancesInfoSync(DescribeNatFwInstancesInfoRequest req)
        {
             JsonResponseModel<DescribeNatFwInstancesInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstancesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstancesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示当前natfw 实例对应的vpc dns开关
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public async Task<DescribeNatFwVpcDnsLstResponse> DescribeNatFwVpcDnsLst(DescribeNatFwVpcDnsLstRequest req)
        {
             JsonResponseModel<DescribeNatFwVpcDnsLstResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwVpcDnsLst");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwVpcDnsLstResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示当前natfw 实例对应的vpc dns开关
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public DescribeNatFwVpcDnsLstResponse DescribeNatFwVpcDnsLstSync(DescribeNatFwVpcDnsLstRequest req)
        {
             JsonResponseModel<DescribeNatFwVpcDnsLstResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwVpcDnsLst");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwVpcDnsLstResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceGroup资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupResponse"/></returns>
        public async Task<DescribeResourceGroupResponse> DescribeResourceGroup(DescribeResourceGroupRequest req)
        {
             JsonResponseModel<DescribeResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceGroup资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupResponse"/></returns>
        public DescribeResourceGroupResponse DescribeResourceGroupSync(DescribeResourceGroupRequest req)
        {
             JsonResponseModel<DescribeResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceGroupNew资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public async Task<DescribeResourceGroupNewResponse> DescribeResourceGroupNew(DescribeResourceGroupNewRequest req)
        {
             JsonResponseModel<DescribeResourceGroupNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceGroupNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceGroupNew资产中心资产树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public DescribeResourceGroupNewResponse DescribeResourceGroupNewSync(DescribeResourceGroupNewRequest req)
        {
             JsonResponseModel<DescribeResourceGroupNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceGroupNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public async Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public async Task<DescribeSecurityGroupListResponse> DescribeSecurityGroupList(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public DescribeSecurityGroupListResponse DescribeSecurityGroupListSync(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSourceAsset-查询资产组全部资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public async Task<DescribeSourceAssetResponse> DescribeSourceAsset(DescribeSourceAssetRequest req)
        {
             JsonResponseModel<DescribeSourceAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSourceAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSourceAsset-查询资产组全部资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public DescribeSourceAssetResponse DescribeSourceAssetSync(DescribeSourceAssetRequest req)
        {
             JsonResponseModel<DescribeSourceAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSourceAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public async Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public async Task<DescribeTLogInfoResponse> DescribeTLogInfo(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public DescribeTLogInfoResponse DescribeTLogInfoSync(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public async Task<DescribeTLogIpListResponse> DescribeTLogIpList(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public DescribeTLogIpListResponse DescribeTLogIpListSync(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public async Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public async Task<DescribeUnHandleEventTabListResponse> DescribeUnHandleEventTabList(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public DescribeUnHandleEventTabListResponse DescribeUnHandleEventTabListSync(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public async Task<ExpandCfwVerticalResponse> ExpandCfwVertical(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public ExpandCfwVerticalResponse ExpandCfwVerticalSync(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public async Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 互联网边界防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public async Task<ModifyAllPublicIPSwitchStatusResponse> ModifyAllPublicIPSwitchStatus(ModifyAllPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 互联网边界防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public ModifyAllPublicIPSwitchStatusResponse ModifyAllPublicIPSwitchStatusSync(ModifyAllPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public async Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VPC防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public async Task<ModifyAllVPCSwitchStatusResponse> ModifyAllVPCSwitchStatus(ModifyAllVPCSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllVPCSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllVPCSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllVPCSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VPC防火墙一键开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public ModifyAllVPCSwitchStatusResponse ModifyAllVPCSwitchStatusSync(ModifyAllVPCSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllVPCSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllVPCSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllVPCSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public async Task<ModifyAssetScanResponse> ModifyAssetScan(ModifyAssetScanRequest req)
        {
             JsonResponseModel<ModifyAssetScanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public ModifyAssetScanResponse ModifyAssetScanSync(ModifyAssetScanRequest req)
        {
             JsonResponseModel<ModifyAssetScanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持对封禁列表、放通列表如下操作：
        /// 批量增加封禁IP、放通IP/域名
        /// 批量删除封禁IP、放通IP/域名
        /// 批量修改封禁IP、放通IP/域名生效事件
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public async Task<ModifyBlockIgnoreListResponse> ModifyBlockIgnoreList(ModifyBlockIgnoreListRequest req)
        {
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public async Task<ModifyBlockTopResponse> ModifyBlockTop(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public ModifyBlockTopResponse ModifyBlockTopSync(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改企业安全组下发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public async Task<ModifyEnterpriseSecurityDispatchStatusResponse> ModifyEnterpriseSecurityDispatchStatus(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
             JsonResponseModel<ModifyEnterpriseSecurityDispatchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnterpriseSecurityDispatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnterpriseSecurityDispatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改企业安全组下发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public ModifyEnterpriseSecurityDispatchStatusResponse ModifyEnterpriseSecurityDispatchStatusSync(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
             JsonResponseModel<ModifyEnterpriseSecurityDispatchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnterpriseSecurityDispatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnterpriseSecurityDispatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public async Task<ModifyEnterpriseSecurityGroupRuleResponse> ModifyEnterpriseSecurityGroupRule(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<ModifyEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public ModifyEnterpriseSecurityGroupRuleResponse ModifyEnterpriseSecurityGroupRuleSync(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<ModifyEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public async Task<ModifyNatAcRuleResponse> ModifyNatAcRule(ModifyNatAcRuleRequest req)
        {
             JsonResponseModel<ModifyNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public ModifyNatAcRuleResponse ModifyNatAcRuleSync(ModifyNatAcRuleRequest req)
        {
             JsonResponseModel<ModifyNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙实例重新选择vpc或nat
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public async Task<ModifyNatFwReSelectResponse> ModifyNatFwReSelect(ModifyNatFwReSelectRequest req)
        {
             JsonResponseModel<ModifyNatFwReSelectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwReSelect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwReSelectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙实例重新选择vpc或nat
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public ModifyNatFwReSelectResponse ModifyNatFwReSelectSync(ModifyNatFwReSelectRequest req)
        {
             JsonResponseModel<ModifyNatFwReSelectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwReSelect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwReSelectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改NAT防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public async Task<ModifyNatFwSwitchResponse> ModifyNatFwSwitch(ModifyNatFwSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改NAT防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public ModifyNatFwSwitchResponse ModifyNatFwSwitchSync(ModifyNatFwSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat 防火墙VPC DNS 开关切换
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public async Task<ModifyNatFwVpcDnsSwitchResponse> ModifyNatFwVpcDnsSwitch(ModifyNatFwVpcDnsSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwVpcDnsSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat 防火墙VPC DNS 开关切换
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public ModifyNatFwVpcDnsSwitchResponse ModifyNatFwVpcDnsSwitchSync(ModifyNatFwVpcDnsSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwVpcDnsSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT防火墙规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public async Task<ModifyNatSequenceRulesResponse> ModifyNatSequenceRules(ModifyNatSequenceRulesRequest req)
        {
             JsonResponseModel<ModifyNatSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT防火墙规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public ModifyNatSequenceRulesResponse ModifyNatSequenceRulesSync(ModifyNatSequenceRulesRequest req)
        {
             JsonResponseModel<ModifyNatSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单个修改互联网边界防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public async Task<ModifyPublicIPSwitchStatusResponse> ModifyPublicIPSwitchStatus(ModifyPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单个修改互联网边界防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public ModifyPublicIPSwitchStatusResponse ModifyPublicIPSwitchStatusSync(ModifyPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyResourceGroup-资产中心资产组信息修改
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public async Task<ModifyResourceGroupResponse> ModifyResourceGroup(ModifyResourceGroupRequest req)
        {
             JsonResponseModel<ModifyResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyResourceGroup-资产中心资产组信息修改
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public ModifyResourceGroupResponse ModifyResourceGroupSync(ModifyResourceGroupRequest req)
        {
             JsonResponseModel<ModifyResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public async Task<ModifyRunSyncAssetResponse> ModifyRunSyncAsset(ModifyRunSyncAssetRequest req)
        {
             JsonResponseModel<ModifyRunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC（新）
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public ModifyRunSyncAssetResponse ModifyRunSyncAssetSync(ModifyRunSyncAssetRequest req)
        {
             JsonResponseModel<ModifyRunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用单条企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public async Task<ModifySecurityGroupItemRuleStatusResponse> ModifySecurityGroupItemRuleStatus(ModifySecurityGroupItemRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupItemRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用单条企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public ModifySecurityGroupItemRuleStatusResponse ModifySecurityGroupItemRuleStatusSync(ModifySecurityGroupItemRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupItemRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑单条安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public async Task<ModifySecurityGroupRuleResponse> ModifySecurityGroupRule(ModifySecurityGroupRuleRequest req)
        {
             JsonResponseModel<ModifySecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑单条安全组规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public ModifySecurityGroupRuleResponse ModifySecurityGroupRuleSync(ModifySecurityGroupRuleRequest req)
        {
             JsonResponseModel<ModifySecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业安全组规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public async Task<ModifySecurityGroupSequenceRulesResponse> ModifySecurityGroupSequenceRules(ModifySecurityGroupSequenceRulesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业安全组规则快速排序
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public ModifySecurityGroupSequenceRulesResponse ModifySecurityGroupSequenceRulesSync(ModifySecurityGroupSequenceRulesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public async Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志存储设置，可以修改存储时间和清空日志
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public async Task<ModifyStorageSettingResponse> ModifyStorageSetting(ModifyStorageSettingRequest req)
        {
             JsonResponseModel<ModifyStorageSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStorageSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStorageSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志存储设置，可以修改存储时间和清空日志
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public ModifyStorageSettingResponse ModifyStorageSettingSync(ModifyStorageSettingRequest req)
        {
             JsonResponseModel<ModifyStorageSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStorageSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStorageSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public async Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public async Task<RemoveAcRuleResponse> RemoveAcRule(RemoveAcRuleRequest req)
        {
             JsonResponseModel<RemoveAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除互联网边界规则
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public RemoveAcRuleResponse RemoveAcRuleSync(RemoveAcRuleRequest req)
        {
             JsonResponseModel<RemoveAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public async Task<RemoveEnterpriseSecurityGroupRuleResponse> RemoveEnterpriseSecurityGroupRule(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除新企业安全组规则
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public RemoveEnterpriseSecurityGroupRuleResponse RemoveEnterpriseSecurityGroupRuleSync(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public async Task<RemoveNatAcRuleResponse> RemoveNatAcRule(RemoveNatAcRuleRequest req)
        {
             JsonResponseModel<RemoveNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除NAT访问控制规则
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public RemoveNatAcRuleResponse RemoveNatAcRuleSync(RemoveNatAcRuleRequest req)
        {
             JsonResponseModel<RemoveNatAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveNatAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNatAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public async Task<SetNatFwDnatRuleResponse> SetNatFwDnatRule(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public SetNatFwDnatRuleResponse SetNatFwDnatRuleSync(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置防火墙实例弹性公网ip，目前仅支持新增模式的防火墙实例
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public async Task<SetNatFwEipResponse> SetNatFwEip(SetNatFwEipRequest req)
        {
             JsonResponseModel<SetNatFwEipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNatFwEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置防火墙实例弹性公网ip，目前仅支持新增模式的防火墙实例
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public SetNatFwEipResponse SetNatFwEipSync(SetNatFwEipRequest req)
        {
             JsonResponseModel<SetNatFwEipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNatFwEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 中止安全组规则下发
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public async Task<StopSecurityGroupRuleDispatchResponse> StopSecurityGroupRuleDispatch(StopSecurityGroupRuleDispatchRequest req)
        {
             JsonResponseModel<StopSecurityGroupRuleDispatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopSecurityGroupRuleDispatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSecurityGroupRuleDispatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 中止安全组规则下发
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public StopSecurityGroupRuleDispatchResponse StopSecurityGroupRuleDispatchSync(StopSecurityGroupRuleDispatchRequest req)
        {
             JsonResponseModel<StopSecurityGroupRuleDispatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopSecurityGroupRuleDispatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSecurityGroupRuleDispatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
