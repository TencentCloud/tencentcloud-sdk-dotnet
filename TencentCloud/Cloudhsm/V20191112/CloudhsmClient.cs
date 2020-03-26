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

namespace TencentCloud.Cloudhsm.V20191112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudhsm.V20191112.Models;

   public class CloudhsmClient : AbstractClient{

       private const string endpoint = "cloudhsm.tencentcloudapi.com";
       private const string version = "2019-11-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudhsmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudhsmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 通过SubnetId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMBySubnetIdRequest"/></param>
        /// <returns><see cref="DescribeHSMBySubnetIdResponse"/></returns>
        public async Task<DescribeHSMBySubnetIdResponse> DescribeHSMBySubnetId(DescribeHSMBySubnetIdRequest req)
        {
             JsonResponseModel<DescribeHSMBySubnetIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHSMBySubnetId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHSMBySubnetIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过SubnetId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMBySubnetIdRequest"/></param>
        /// <returns><see cref="DescribeHSMBySubnetIdResponse"/></returns>
        public DescribeHSMBySubnetIdResponse DescribeHSMBySubnetIdSync(DescribeHSMBySubnetIdRequest req)
        {
             JsonResponseModel<DescribeHSMBySubnetIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHSMBySubnetId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHSMBySubnetIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过VpcId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMByVpcIdRequest"/></param>
        /// <returns><see cref="DescribeHSMByVpcIdResponse"/></returns>
        public async Task<DescribeHSMByVpcIdResponse> DescribeHSMByVpcId(DescribeHSMByVpcIdRequest req)
        {
             JsonResponseModel<DescribeHSMByVpcIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHSMByVpcId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHSMByVpcIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过VpcId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMByVpcIdRequest"/></param>
        /// <returns><see cref="DescribeHSMByVpcIdResponse"/></returns>
        public DescribeHSMByVpcIdResponse DescribeHSMByVpcIdSync(DescribeHSMByVpcIdRequest req)
        {
             JsonResponseModel<DescribeHSMByVpcIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHSMByVpcId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHSMByVpcIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetRequest"/></param>
        /// <returns><see cref="DescribeSubnetResponse"/></returns>
        public async Task<DescribeSubnetResponse> DescribeSubnet(DescribeSubnetRequest req)
        {
             JsonResponseModel<DescribeSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetRequest"/></param>
        /// <returns><see cref="DescribeSubnetResponse"/></returns>
        public DescribeSubnetResponse DescribeSubnetSync(DescribeSubnetRequest req)
        {
             JsonResponseModel<DescribeSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据用户的AppId获取用户安全组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRequest"/></param>
        /// <returns><see cref="DescribeUsgResponse"/></returns>
        public async Task<DescribeUsgResponse> DescribeUsg(DescribeUsgRequest req)
        {
             JsonResponseModel<DescribeUsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据用户的AppId获取用户安全组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRequest"/></param>
        /// <returns><see cref="DescribeUsgResponse"/></returns>
        public DescribeUsgResponse DescribeUsgSync(DescribeUsgRequest req)
        {
             JsonResponseModel<DescribeUsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRuleRequest"/></param>
        /// <returns><see cref="DescribeUsgRuleResponse"/></returns>
        public async Task<DescribeUsgRuleResponse> DescribeUsgRule(DescribeUsgRuleRequest req)
        {
             JsonResponseModel<DescribeUsgRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsgRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsgRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRuleRequest"/></param>
        /// <returns><see cref="DescribeUsgRuleResponse"/></returns>
        public DescribeUsgRuleResponse DescribeUsgRuleSync(DescribeUsgRuleRequest req)
        {
             JsonResponseModel<DescribeUsgRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsgRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsgRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRequest"/></param>
        /// <returns><see cref="DescribeVpcResponse"/></returns>
        public async Task<DescribeVpcResponse> DescribeVpc(DescribeVpcRequest req)
        {
             JsonResponseModel<DescribeVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRequest"/></param>
        /// <returns><see cref="DescribeVpcResponse"/></returns>
        public DescribeVpcResponse DescribeVpcSync(DescribeVpcRequest req)
        {
             JsonResponseModel<DescribeVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取VSM属性
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmAttributesRequest"/></param>
        /// <returns><see cref="DescribeVsmAttributesResponse"/></returns>
        public async Task<DescribeVsmAttributesResponse> DescribeVsmAttributes(DescribeVsmAttributesRequest req)
        {
             JsonResponseModel<DescribeVsmAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVsmAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVsmAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取VSM属性
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmAttributesRequest"/></param>
        /// <returns><see cref="DescribeVsmAttributesResponse"/></returns>
        public DescribeVsmAttributesResponse DescribeVsmAttributesSync(DescribeVsmAttributesRequest req)
        {
             JsonResponseModel<DescribeVsmAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVsmAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVsmAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户VSM列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmsRequest"/></param>
        /// <returns><see cref="DescribeVsmsResponse"/></returns>
        public async Task<DescribeVsmsResponse> DescribeVsms(DescribeVsmsRequest req)
        {
             JsonResponseModel<DescribeVsmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVsms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVsmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户VSM列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmsRequest"/></param>
        /// <returns><see cref="DescribeVsmsResponse"/></returns>
        public DescribeVsmsResponse DescribeVsmsSync(DescribeVsmsRequest req)
        {
             JsonResponseModel<DescribeVsmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVsms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVsmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买询价接口
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceBuyVsmRequest"/></param>
        /// <returns><see cref="InquiryPriceBuyVsmResponse"/></returns>
        public async Task<InquiryPriceBuyVsmResponse> InquiryPriceBuyVsm(InquiryPriceBuyVsmRequest req)
        {
             JsonResponseModel<InquiryPriceBuyVsmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceBuyVsm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceBuyVsmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买询价接口
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceBuyVsmRequest"/></param>
        /// <returns><see cref="InquiryPriceBuyVsmResponse"/></returns>
        public InquiryPriceBuyVsmResponse InquiryPriceBuyVsmSync(InquiryPriceBuyVsmRequest req)
        {
             JsonResponseModel<InquiryPriceBuyVsmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceBuyVsm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceBuyVsmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改VSM属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVsmAttributesRequest"/></param>
        /// <returns><see cref="ModifyVsmAttributesResponse"/></returns>
        public async Task<ModifyVsmAttributesResponse> ModifyVsmAttributes(ModifyVsmAttributesRequest req)
        {
             JsonResponseModel<ModifyVsmAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVsmAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVsmAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改VSM属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVsmAttributesRequest"/></param>
        /// <returns><see cref="ModifyVsmAttributesResponse"/></returns>
        public ModifyVsmAttributesResponse ModifyVsmAttributesSync(ModifyVsmAttributesRequest req)
        {
             JsonResponseModel<ModifyVsmAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVsmAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVsmAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
