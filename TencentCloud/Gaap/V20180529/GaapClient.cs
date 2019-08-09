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

namespace TencentCloud.Gaap.V20180529
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gaap.V20180529.Models;

   public class GaapClient : AbstractClient{

       private const string endpoint = "gaap.tencentcloudapi.com";
       private const string version = "2018-05-29";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public GaapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public GaapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加源站(服务器)信息，支持IP或域名
        /// </summary>
        /// <param name="req">参考<see cref="AddRealServersRequest"/></param>
        /// <returns>参考<see cref="AddRealServersResponse"/>实例</returns>
        public async Task<AddRealServersResponse> AddRealServers(AddRealServersRequest req)
        {
             JsonResponseModel<AddRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindListenerRealServers）用于TCP/UDP监听器绑定解绑源站。
        /// 注意：本接口会解绑之前绑定的源站，绑定本次调用所选择的源站。例如：原来绑定的源站为A，B，C，本次调用的选择绑定的源站为C，D，E，那么调用后所绑定的源站为C，D，E。
        /// </summary>
        /// <param name="req">参考<see cref="BindListenerRealServersRequest"/></param>
        /// <returns>参考<see cref="BindListenerRealServersResponse"/>实例</returns>
        public async Task<BindListenerRealServersResponse> BindListenerRealServers(BindListenerRealServersRequest req)
        {
             JsonResponseModel<BindListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于7层监听器转发规则绑定源站。
        /// </summary>
        /// <param name="req">参考<see cref="BindRuleRealServersRequest"/></param>
        /// <returns>参考<see cref="BindRuleRealServersResponse"/>实例</returns>
        public async Task<BindRuleRealServersResponse> BindRuleRealServers(BindRuleRealServersRequest req)
        {
             JsonResponseModel<BindRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CheckProxyCreate)用于查询能否创建指定配置的加速通道。
        /// </summary>
        /// <param name="req">参考<see cref="CheckProxyCreateRequest"/></param>
        /// <returns>参考<see cref="CheckProxyCreateResponse"/>实例</returns>
        public async Task<CheckProxyCreateResponse> CheckProxyCreate(CheckProxyCreateRequest req)
        {
             JsonResponseModel<CheckProxyCreateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckProxyCreate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckProxyCreateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloseProxies）用于关闭通道。通道关闭后，不再产生流量，但每天仍然收取通道基础配置费用。
        /// </summary>
        /// <param name="req">参考<see cref="CloseProxiesRequest"/></param>
        /// <returns>参考<see cref="CloseProxiesResponse"/>实例</returns>
        public async Task<CloseProxiesResponse> CloseProxies(CloseProxiesRequest req)
        {
             JsonResponseModel<CloseProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭安全策略
        /// </summary>
        /// <param name="req">参考<see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns>参考<see cref="CloseSecurityPolicyResponse"/>实例</returns>
        public async Task<CloseSecurityPolicyResponse> CloseSecurityPolicy(CloseSecurityPolicyRequest req)
        {
             JsonResponseModel<CloseSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建Gaap相关证书和配置文件，包括基础认证配置文件，客户端CA证书，服务器SSL证书，Gaap SSL证书以及源站CA证书。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCertificateRequest"/></param>
        /// <returns>参考<see cref="CreateCertificateResponse"/>实例</returns>
        public async Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDomain）用于创建HTTP/HTTPS监听器的访问域名，客户端请求通过访问该域名来请求后端业务。
        /// 该接口仅支持version3.0的通道。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDomainRequest"/></param>
        /// <returns>参考<see cref="CreateDomainResponse"/>实例</returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateHTTPListener）用于在通道实例下创建HTTP协议类型的监听器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateHTTPListenerRequest"/></param>
        /// <returns>参考<see cref="CreateHTTPListenerResponse"/>实例</returns>
        public async Task<CreateHTTPListenerResponse> CreateHTTPListener(CreateHTTPListenerRequest req)
        {
             JsonResponseModel<CreateHTTPListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHTTPListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateHTTPSListener）用于在通道实例下创建HTTPS协议类型的监听器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns>参考<see cref="CreateHTTPSListenerResponse"/>实例</returns>
        public async Task<CreateHTTPSListenerResponse> CreateHTTPSListener(CreateHTTPSListenerRequest req)
        {
             JsonResponseModel<CreateHTTPSListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHTTPSListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPSListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProxy）用于创建一个指定配置的加速通道。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProxyRequest"/></param>
        /// <returns>参考<see cref="CreateProxyResponse"/>实例</returns>
        public async Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
             JsonResponseModel<CreateProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProxyGroup）用于创建通道组。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProxyGroupRequest"/></param>
        /// <returns>参考<see cref="CreateProxyGroupResponse"/>实例</returns>
        public async Task<CreateProxyGroupResponse> CreateProxyGroup(CreateProxyGroupRequest req)
        {
             JsonResponseModel<CreateProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProxyGroupDomain）用于创建通道组域名，并开启域名解析。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns>参考<see cref="CreateProxyGroupDomainResponse"/>实例</returns>
        public async Task<CreateProxyGroupDomainResponse> CreateProxyGroupDomain(CreateProxyGroupDomainRequest req)
        {
             JsonResponseModel<CreateProxyGroupDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxyGroupDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateRule）用于创建HTTP/HTTPS监听器转发规则。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRuleRequest"/></param>
        /// <returns>参考<see cref="CreateRuleResponse"/>实例</returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全策略
        /// </summary>
        /// <param name="req">参考<see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateSecurityPolicyResponse"/>实例</returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加安全策略规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateSecurityRulesRequest"/></param>
        /// <returns>参考<see cref="CreateSecurityRulesResponse"/>实例</returns>
        public async Task<CreateSecurityRulesResponse> CreateSecurityRules(CreateSecurityRulesRequest req)
        {
             JsonResponseModel<CreateSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateTCPListeners）用于批量创建单通道或者通道组的TCP协议类型的监听器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateTCPListenersRequest"/></param>
        /// <returns>参考<see cref="CreateTCPListenersResponse"/>实例</returns>
        public async Task<CreateTCPListenersResponse> CreateTCPListeners(CreateTCPListenersRequest req)
        {
             JsonResponseModel<CreateTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateUDPListeners）用于批量创建单通道或者通道组的UDP协议类型的监听器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateUDPListenersRequest"/></param>
        /// <returns>参考<see cref="CreateUDPListenersResponse"/>实例</returns>
        public async Task<CreateUDPListenersResponse> CreateUDPListeners(CreateUDPListenersRequest req)
        {
             JsonResponseModel<CreateUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCertificateRequest"/></param>
        /// <returns>参考<see cref="DeleteCertificateResponse"/>实例</returns>
        public async Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDomain）仅适用于7层监听器，用于删除该监听器下对应域名及域名下的所有规则，所有已绑定源站的规则将自动解绑。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDomainRequest"/></param>
        /// <returns>参考<see cref="DeleteDomainResponse"/>实例</returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteListeners）用于批量删除通道或通道组的监听器，包括4/7层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteListenersRequest"/></param>
        /// <returns>参考<see cref="DeleteListenersResponse"/>实例</returns>
        public async Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
             JsonResponseModel<DeleteListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProxyGroup）用于删除通道组。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProxyGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteProxyGroupResponse"/>实例</returns>
        public async Task<DeleteProxyGroupResponse> DeleteProxyGroup(DeleteProxyGroupRequest req)
        {
             JsonResponseModel<DeleteProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteRule）用于删除HTTP/HTTPS监听器的转发规则。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteRuleResponse"/>实例</returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全策略
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteSecurityPolicyResponse"/>实例</returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全策略规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns>参考<see cref="DeleteSecurityRulesResponse"/>实例</returns>
        public async Task<DeleteSecurityRulesResponse> DeleteSecurityRules(DeleteSecurityRulesRequest req)
        {
             JsonResponseModel<DeleteSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccessRegions）用于查询加速区域，即客户端接入区域。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccessRegionsResponse"/>实例</returns>
        public async Task<DescribeAccessRegionsResponse> DescribeAccessRegions(DescribeAccessRegionsRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccessRegionsByDestRegion）根据源站区域查询可用的加速区域列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns>参考<see cref="DescribeAccessRegionsByDestRegionResponse"/>实例</returns>
        public async Task<DescribeAccessRegionsByDestRegionResponse> DescribeAccessRegionsByDestRegion(DescribeAccessRegionsByDestRegionRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsByDestRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessRegionsByDestRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsByDestRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificateDetail）用于查询证书详情，包括证书ID，证书名字，证书类型，证书内容以及密钥等信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeCertificateDetailResponse"/>实例</returns>
        public async Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用来查询可以使用的证书列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCertificatesRequest"/></param>
        /// <returns>参考<see cref="DescribeCertificatesResponse"/>实例</returns>
        public async Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCountryAreaMapping）用于获取国家地区编码映射表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns>参考<see cref="DescribeCountryAreaMappingResponse"/>实例</returns>
        public async Task<DescribeCountryAreaMappingResponse> DescribeCountryAreaMapping(DescribeCountryAreaMappingRequest req)
        {
             JsonResponseModel<DescribeCountryAreaMappingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCountryAreaMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCountryAreaMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDestRegions）用于查询源站区域，即源站服务器所在区域。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDestRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeDestRegionsResponse"/>实例</returns>
        public async Task<DescribeDestRegionsResponse> DescribeDestRegions(DescribeDestRegionsRequest req)
        {
             JsonResponseModel<DescribeDestRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDestRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDestRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道组和通道信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupAndStatisticsProxyResponse"/>实例</returns>
        public async Task<DescribeGroupAndStatisticsProxyResponse> DescribeGroupAndStatisticsProxy(DescribeGroupAndStatisticsProxyRequest req)
        {
             JsonResponseModel<DescribeGroupAndStatisticsProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupAndStatisticsProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupAndStatisticsProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGroupDomainConfig）用于获取通道组域名解析配置详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupDomainConfigResponse"/>实例</returns>
        public async Task<DescribeGroupDomainConfigResponse> DescribeGroupDomainConfig(DescribeGroupDomainConfigRequest req)
        {
             JsonResponseModel<DescribeGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeHTTPListeners）用来查询HTTP监听器信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeHTTPListenersResponse"/>实例</returns>
        public async Task<DescribeHTTPListenersResponse> DescribeHTTPListeners(DescribeHTTPListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHTTPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeHTTPSListeners）用来查询HTTPS监听器信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeHTTPSListenersResponse"/>实例</returns>
        public async Task<DescribeHTTPSListenersResponse> DescribeHTTPSListeners(DescribeHTTPSListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPSListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHTTPSListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPSListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeListenerRealServers）用于查询TCP/UDP监听器源站列表，包括该监听器已经绑定的源站列表以及可以绑定的源站列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns>参考<see cref="DescribeListenerRealServersResponse"/>实例</returns>
        public async Task<DescribeListenerRealServersResponse> DescribeListenerRealServers(DescribeListenerRealServersRequest req)
        {
             JsonResponseModel<DescribeListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeListenerStatisticsResponse"/>实例</returns>
        public async Task<DescribeListenerStatisticsResponse> DescribeListenerStatistics(DescribeListenerStatisticsRequest req)
        {
             JsonResponseModel<DescribeListenerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListenerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxies）用于查询通道实例列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxiesRequest"/></param>
        /// <returns>参考<see cref="DescribeProxiesResponse"/>实例</returns>
        public async Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
             JsonResponseModel<DescribeProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxiesStatus）用于查询通道状态列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeProxiesStatusResponse"/>实例</returns>
        public async Task<DescribeProxiesStatusResponse> DescribeProxiesStatus(DescribeProxiesStatusRequest req)
        {
             JsonResponseModel<DescribeProxiesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxiesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道和监听器信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyAndStatisticsListenersResponse"/>实例</returns>
        public async Task<DescribeProxyAndStatisticsListenersResponse> DescribeProxyAndStatisticsListeners(DescribeProxyAndStatisticsListenersRequest req)
        {
             JsonResponseModel<DescribeProxyAndStatisticsListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyAndStatisticsListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyAndStatisticsListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxyDetail）用于查询通道详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyDetailResponse"/>实例</returns>
        public async Task<DescribeProxyDetailResponse> DescribeProxyDetail(DescribeProxyDetailRequest req)
        {
             JsonResponseModel<DescribeProxyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupDetails）用于查询通道组详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyGroupDetailsResponse"/>实例</returns>
        public async Task<DescribeProxyGroupDetailsResponse> DescribeProxyGroupDetails(DescribeProxyGroupDetailsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupList）用于拉取通道组列表及各通道组基本信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyGroupListResponse"/>实例</returns>
        public async Task<DescribeProxyGroupListResponse> DescribeProxyGroupList(DescribeProxyGroupListRequest req)
        {
             JsonResponseModel<DescribeProxyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyGroupStatisticsResponse"/>实例</returns>
        public async Task<DescribeProxyGroupStatisticsResponse> DescribeProxyGroupStatistics(DescribeProxyGroupStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发，丢包和时延数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeProxyStatisticsResponse"/>实例</returns>
        public async Task<DescribeProxyStatisticsResponse> DescribeProxyStatistics(DescribeProxyStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeRealServerStatistics）用于查询源站健康检查结果的统计数据。源站状态展示位为1：正常或者0：异常。查询的源站需要在监听器或者规则上进行了绑定，查询时需指定绑定的监听器或者规则ID。该接口支持最近1，3，6，12，24小时内1分钟细粒度的源站状态统计数据展示。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeRealServerStatisticsResponse"/>实例</returns>
        public async Task<DescribeRealServerStatisticsResponse> DescribeRealServerStatistics(DescribeRealServerStatisticsRequest req)
        {
             JsonResponseModel<DescribeRealServerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRealServers）用于查询源站信息，可以根据项目名查询所有的源站信息，此外支持指定IP机或者域名的源站模糊查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRealServersRequest"/></param>
        /// <returns>参考<see cref="DescribeRealServersResponse"/>实例</returns>
        public async Task<DescribeRealServersResponse> DescribeRealServers(DescribeRealServersRequest req)
        {
             JsonResponseModel<DescribeRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRealServersStatus）用于查询源站是否已被规则或者监听器绑定
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeRealServersStatusResponse"/>实例</returns>
        public async Task<DescribeRealServersStatusResponse> DescribeRealServersStatus(DescribeRealServersStatusRequest req)
        {
             JsonResponseModel<DescribeRealServersStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServersStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeRegionAndPrice）用于获取源站区域和带宽梯度价格
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeRegionAndPriceResponse"/>实例</returns>
        public async Task<DescribeRegionAndPriceResponse> DescribeRegionAndPrice(DescribeRegionAndPriceRequest req)
        {
             JsonResponseModel<DescribeRegionAndPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegionAndPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionAndPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeResourcesByTag）用于根据标签来查询对应的资源信息，包括通道，通道组和源站。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns>参考<see cref="DescribeResourcesByTagResponse"/>实例</returns>
        public async Task<DescribeResourcesByTagResponse> DescribeResourcesByTag(DescribeResourcesByTagRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRuleRealServers）用于查询转发规则相关的源站信息， 包括该规则可绑定的源站信息和已绑定的源站信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns>参考<see cref="DescribeRuleRealServersResponse"/>实例</returns>
        public async Task<DescribeRuleRealServersResponse> DescribeRuleRealServers(DescribeRuleRealServersRequest req)
        {
             JsonResponseModel<DescribeRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRules）用于查询监听器下的所有规则信息，包括规则域名，路径以及该规则下所绑定的源站列表。当通道版本为3.0时，该接口会返回该域名对应的高级认证配置信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeRulesResponse"/>实例</returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全策略详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityPolicyDetailResponse"/>实例</returns>
        public async Task<DescribeSecurityPolicyDetailResponse> DescribeSecurityPolicyDetail(DescribeSecurityPolicyDetailRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeTCPListeners）用于查询单通道或者通道组下的TCP监听器信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTCPListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeTCPListenersResponse"/>实例</returns>
        public async Task<DescribeTCPListenersResponse> DescribeTCPListeners(DescribeTCPListenersRequest req)
        {
             JsonResponseModel<DescribeTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeUDPListeners）用于查询单通道或者通道组下的UDP监听器信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUDPListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeUDPListenersResponse"/>实例</returns>
        public async Task<DescribeUDPListenersResponse> DescribeUDPListeners(DescribeUDPListenersRequest req)
        {
             JsonResponseModel<DescribeUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyProxies）用于销毁。通道销毁后，不再产生任何费用。
        /// </summary>
        /// <param name="req">参考<see cref="DestroyProxiesRequest"/></param>
        /// <returns>参考<see cref="DestroyProxiesResponse"/>实例</returns>
        public async Task<DestroyProxiesResponse> DestroyProxies(DestroyProxiesRequest req)
        {
             JsonResponseModel<DestroyProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateProxy）用于创建加速通道询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateProxyResponse"/>实例</returns>
        public async Task<InquiryPriceCreateProxyResponse> InquiryPriceCreateProxy(InquiryPriceCreateProxyRequest req)
        {
             JsonResponseModel<InquiryPriceCreateProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCertificate）用于修改监听器下的域名对应的证书。该接口仅适用于version3.0的通道。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCertificateRequest"/></param>
        /// <returns>参考<see cref="ModifyCertificateResponse"/>实例</returns>
        public async Task<ModifyCertificateResponse> ModifyCertificate(ModifyCertificateRequest req)
        {
             JsonResponseModel<ModifyCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCertificateAttributes）用于修改证书，包括证明名字以及证书内容。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns>参考<see cref="ModifyCertificateAttributesResponse"/>实例</returns>
        public async Task<ModifyCertificateAttributesResponse> ModifyCertificateAttributes(ModifyCertificateAttributesRequest req)
        {
             JsonResponseModel<ModifyCertificateAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDomain）用于监听器下的域名。当通道版本为3.0时，支持对该域名所对应的证书修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDomainRequest"/></param>
        /// <returns>参考<see cref="ModifyDomainResponse"/>实例</returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyGroupDomainConfig）用于配置通道组就近接入域名。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyGroupDomainConfigResponse"/>实例</returns>
        public async Task<ModifyGroupDomainConfigResponse> ModifyGroupDomainConfig(ModifyGroupDomainConfigRequest req)
        {
             JsonResponseModel<ModifyGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（ModifyHTTPListenerAttribute）用于修改通道的HTTP监听器配置信息，目前仅支持修改监听器的名称。
        /// 注意：通道组通道暂时不支持HTTP/HTTPS监听器。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyHTTPListenerAttributeResponse"/>实例</returns>
        public async Task<ModifyHTTPListenerAttributeResponse> ModifyHTTPListenerAttribute(ModifyHTTPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHTTPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（ModifyHTTPSListenerAttribute）用于修改HTTPS监听器配置，当前不支持通道组和v1版本通道。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyHTTPSListenerAttributeResponse"/>实例</returns>
        public async Task<ModifyHTTPSListenerAttributeResponse> ModifyHTTPSListenerAttribute(ModifyHTTPSListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPSListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHTTPSListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPSListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProxiesAttribute）用于修改实例的属性（目前只支持修改通道的名称）。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyProxiesAttributeResponse"/>实例</returns>
        public async Task<ModifyProxiesAttributeResponse> ModifyProxiesAttribute(ModifyProxiesAttributeRequest req)
        {
             JsonResponseModel<ModifyProxiesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxiesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProxiesProject）用于修改通道所属项目。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyProxiesProjectResponse"/>实例</returns>
        public async Task<ModifyProxiesProjectResponse> ModifyProxiesProject(ModifyProxiesProjectRequest req)
        {
             JsonResponseModel<ModifyProxiesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxiesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProxyConfiguration）用于修改通道的配置。根据当前业务的容量需求，扩容或缩容相关通道的配置。仅支持Scalarable为1的通道,Scalarable可通过接口DescribeProxies获取。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns>参考<see cref="ModifyProxyConfigurationResponse"/>实例</returns>
        public async Task<ModifyProxyConfigurationResponse> ModifyProxyConfiguration(ModifyProxyConfigurationRequest req)
        {
             JsonResponseModel<ModifyProxyConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxyConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProxyGroupAttribute）用于修改通道组属性，目前仅支持修改通道组名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyProxyGroupAttributeResponse"/>实例</returns>
        public async Task<ModifyProxyGroupAttributeResponse> ModifyProxyGroupAttribute(ModifyProxyGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyProxyGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxyGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyRealServerName）用于修改源站的名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRealServerNameRequest"/></param>
        /// <returns>参考<see cref="ModifyRealServerNameResponse"/>实例</returns>
        public async Task<ModifyRealServerNameResponse> ModifyRealServerName(ModifyRealServerNameRequest req)
        {
             JsonResponseModel<ModifyRealServerNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRealServerName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRealServerNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyRuleAttribute）用于修改转发规则的信息，包括健康检查的配置以及转发策略。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyRuleAttributeResponse"/>实例</returns>
        public async Task<ModifyRuleAttributeResponse> ModifyRuleAttribute(ModifyRuleAttributeRequest req)
        {
             JsonResponseModel<ModifyRuleAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRuleAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全策略规则名
        /// </summary>
        /// <param name="req">参考<see cref="ModifySecurityRuleRequest"/></param>
        /// <returns>参考<see cref="ModifySecurityRuleResponse"/>实例</returns>
        public async Task<ModifySecurityRuleResponse> ModifySecurityRule(ModifySecurityRuleRequest req)
        {
             JsonResponseModel<ModifySecurityRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyTCPListenerAttribute）用于修改通道实例下TCP监听器配置，包括健康检查的配置，调度策略。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyTCPListenerAttributeResponse"/>实例</returns>
        public async Task<ModifyTCPListenerAttributeResponse> ModifyTCPListenerAttribute(ModifyTCPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyTCPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTCPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTCPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyUDPListenerAttribute）用于修改通道实例下UDP监听器配置，包括监听器名称和调度策略的修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyUDPListenerAttributeResponse"/>实例</returns>
        public async Task<ModifyUDPListenerAttributeResponse> ModifyUDPListenerAttribute(ModifyUDPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyUDPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUDPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUDPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（OpenProxies）用于开启一条或者多条通道。
        /// </summary>
        /// <param name="req">参考<see cref="OpenProxiesRequest"/></param>
        /// <returns>参考<see cref="OpenProxiesResponse"/>实例</returns>
        public async Task<OpenProxiesResponse> OpenProxies(OpenProxiesRequest req)
        {
             JsonResponseModel<OpenProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启安全策略
        /// </summary>
        /// <param name="req">参考<see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns>参考<see cref="OpenSecurityPolicyResponse"/>实例</returns>
        public async Task<OpenSecurityPolicyResponse> OpenSecurityPolicy(OpenSecurityPolicyRequest req)
        {
             JsonResponseModel<OpenSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除已添加的源站(服务器)IP或域名
        /// </summary>
        /// <param name="req">参考<see cref="RemoveRealServersRequest"/></param>
        /// <returns>参考<see cref="RemoveRealServersResponse"/>实例</returns>
        public async Task<RemoveRealServersResponse> RemoveRealServers(RemoveRealServersRequest req)
        {
             JsonResponseModel<RemoveRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetAuthentication）用于通道的高级认证配置，包括认证方式选择，以及各种认证方式对应的证书选择。仅支持Version3.0的通道。
        /// </summary>
        /// <param name="req">参考<see cref="SetAuthenticationRequest"/></param>
        /// <returns>参考<see cref="SetAuthenticationResponse"/>实例</returns>
        public async Task<SetAuthenticationResponse> SetAuthentication(SetAuthenticationRequest req)
        {
             JsonResponseModel<SetAuthenticationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAuthentication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAuthenticationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
